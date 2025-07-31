using System.Reflection;

namespace SS.MediatR.Options;

public sealed class MediatROptions
{
    internal List<Assembly> Assemblies { get; set; } = new List<Assembly>();
    internal List<Type> PipelineBehaviors { get; set; } = new List<Type>();

    public void RegisterAssembly(Assembly assembly)
    {
        Assemblies.Add(assembly);
    }

    public void RegisterServiceFromAssemblies(params Assembly[] assemblies)
    {
        Assemblies.AddRange(assemblies);
    }

    public void AddOpenBehavior(Type behaviorType)
    {
        PipelineBehaviors.Add(behaviorType);
    }

}
