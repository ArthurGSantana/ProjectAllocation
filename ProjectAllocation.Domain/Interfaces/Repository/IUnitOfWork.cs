namespace ProjectAllocation.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        ICollaboratorRepository CollaboratorRepository { get; }
        bool Commit();
    }
}
