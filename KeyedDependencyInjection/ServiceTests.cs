using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace KeyedDependencyInjection;

public class Tests
{
    private ServiceProvider serviceProvider = null!;

    [SetUp]
    public void Setup()
    {
        serviceProvider = new ServiceCollection()
            .AddKeyedTransient<IDependency, DependencyA>("A")
            .AddKeyedTransient<IDependency, DependencyB>("B")
            .AddTransient<ServiceA>()
            .AddTransient<ServiceB>()
            .BuildServiceProvider();
    }

    [Test]
    public void DependencyAIsInjectedInServiceA()
    {
        var service = serviceProvider.GetRequiredService<ServiceA>();

        service.InvokeSomeMethod().Should().Be("A");
    }

    [Test]
    public void DependencyBIsInjectedInServiceB()
    {
        var service = serviceProvider.GetRequiredService<ServiceB>();

        service.InvokeSomeMethod().Should().Be("B");
    }
}