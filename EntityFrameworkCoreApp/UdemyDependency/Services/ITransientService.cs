namespace UdemyDependency.Services
{
    public interface ServiceBase
    {
        string GuidId { get; }
    }
    public interface ITransientService:ServiceBase
    {
    }
    public interface IScoppedService : ServiceBase
    {
    }
    public interface ISingletonService : ServiceBase
    {
    }
}
