using Blazor.Server.Sample.Models;

namespace Blazor.Server.Sample.Services
{
    public class KubernetesService : IKubernetesService
    {
        public KubernetesService() 
        {
        }

        public IEnumerable<Node> Nodes { get => GetNodes(); private set => throw new NotImplementedException(); }

        private static IEnumerable<Node> GetNodes()
        {
            var list = new List<Node>();
            list.Add(new Node { State = NodeState.Ready });

            return list;
        }
    }
}
