using Microsoft.Extensions.DependencyInjection;

namespace KeyedDependencyInjection;
public class ServiceA
{
    private readonly IDependency dependency;

    public ServiceA([FromKeyedServices("A")] IDependency dependency)
    {
        this.dependency = dependency;
    }

    public string InvokeSomeMethod() => this.dependency.SomeMethod();
}
