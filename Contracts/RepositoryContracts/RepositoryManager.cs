namespace Contracts.RepositoryContracts;

public interface IRepositoryManager
{
    public IUserRepository UserRepository {get;}
    public IRoleRepository RoleRepository {get;}
    public ITokenRepository TokenRepository {get;}

    public Task Save();
}