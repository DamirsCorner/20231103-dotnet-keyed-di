using Microsoft.Extensions.DependencyInjection;

namespace KeyedDependencyInjection;
public class ServiceB
{
    private readonly IDependency dependency;

    public ServiceB([FromKeyedServices("B")] IDependency dependency)
    {
        this.dependency = dependency;
    }

    public string InvokeSomeMethod() => this.dependency.SomeMethod();
}
