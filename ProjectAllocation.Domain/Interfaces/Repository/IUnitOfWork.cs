namespace ProjectAllocation.Domain.Interfaces.Repository
{
    public interface IUnitOfWork
    {
        ICollaboratorRepository CollaboratorRepository { get; }
        IAddressRepository AddressRepository { get; }
        bool Commit();
    }
}
