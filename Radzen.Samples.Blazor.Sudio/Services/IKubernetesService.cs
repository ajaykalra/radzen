using Blazor.Server.Sample.Models;

namespace Blazor.Server.Sample.Services
{
    public interface IKubernetesService
    {
        IEnumerable<Node> Nodes { get; }
    }
}
