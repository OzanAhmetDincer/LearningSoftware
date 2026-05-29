using AlgorithmRunner.Domain.Abstractions;
using System.Reflection;

namespace AlgorithmRunner.Application.Discovery
{
    public static class AlgorithmDiscoverer
    {
        public static List<IAlgorithm> Discover()
        {
            var algorithmType = typeof(IAlgorithm);

            var types = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => algorithmType.IsAssignableFrom(t)
                            && t.IsClass
                            && !t.IsAbstract);

            var algorithms = new List<IAlgorithm>();

            foreach (var type in types)
            {
                if (Activator.CreateInstance(type) is IAlgorithm instance)
                {
                    algorithms.Add(instance);
                }
            }

            return algorithms;
        }
    }
}
