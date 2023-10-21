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
            .AddTransient<DependencyA>()
            .AddTransient<DependencyB>()
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