using AlgorithmRunner.Application.Discovery;
using AlgorithmRunner.Application.Engine;

var algorithms = AlgorithmDiscoverer.Discover();

var engine = new AlgorithmEngine(algorithms);

engine.Run();