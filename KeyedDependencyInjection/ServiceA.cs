namespace KeyedDependencyInjection;
public class ServiceA
{
    private readonly IDependency dependency;

    public ServiceA(DependencyResolver dependencyResolver)
    {
        this.dependency = dependencyResolver("A");
    }

    public string InvokeSomeMethod() => this.dependency.SomeMethod();
}
