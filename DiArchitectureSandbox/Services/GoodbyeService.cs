using DiArchitectureSandbox.Core.Bootstrapping;

namespace DiArchitectureSandbox.Services;

public class GoodbyeService : IDiScoped
{
    public string SayGoodbye() => "Adios!";
}
