namespace KeyedDependencyInjection;
public class ServiceB
{
    private readonly IDependency dependency;

    public ServiceB(DependencyB dependency)
    {
        this.dependency = dependency;
    }

    public string InvokeSomeMethod() => this.dependency.SomeMethod();
}
