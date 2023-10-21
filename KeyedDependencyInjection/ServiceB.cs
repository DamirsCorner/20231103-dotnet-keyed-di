namespace KeyedDependencyInjection;
public class ServiceB
{
    private readonly IDependency dependency;

    public ServiceB(DependencyResolver dependencyResolver)
    {
        this.dependency = dependencyResolver("B");
    }

    public string InvokeSomeMethod() => this.dependency.SomeMethod();
}
