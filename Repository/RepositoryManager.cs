namespace Repository;

using Contracts.RepositoryContracts;

public sealed class RepositoryManager : IRepositoryManager 
{
    Lazy<IUserRepository> userRepository;
    Lazy<IRoleRepository> _roleRepository;

    Lazy<ITokenRepository> _tokenRepository;
    RepositoryContext _repositoryContext;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
        _roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(repositoryContext));

        _tokenRepository = new Lazy<ITokenRepository>(() => new TokenRepository(_repositoryContext));
    }

    public IUserRepository UserRepository => userRepository.Value;
    public IRoleRepository RoleRepository => _roleRepository.Value;
    public async Task Save() => await _repositoryContext.SaveChangesAsync();

    public ITokenRepository TokenRepository => _tokenRepository.Value;
    

    

}