using DiArchitectureSandbox.Core.Bootstrapping;

namespace DiArchitectureSandbox.Services;

public class HelloService : IDiSingleton
{
    public string SayHello(string name) => $"Hello, {name}!";
}
