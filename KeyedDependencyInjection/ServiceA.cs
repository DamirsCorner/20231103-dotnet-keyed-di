namespace KeyedDependencyInjection;
public class ServiceA
{
    private readonly IDependency dependency;

    public ServiceA(DependencyA dependency)
    {
        this.dependency = dependency;
    }

    public string InvokeSomeMethod() => this.dependency.SomeMethod();
}
