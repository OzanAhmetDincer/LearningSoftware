namespace AlgorithmRunner.Domain.Abstractions
{
    public interface IAlgorithm
    {
        string Name { get; }
        string Description { get; }
        void Execute();
    }
}
