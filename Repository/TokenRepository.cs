using Contracts.RepositoryContracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Shared.DTOs.UserDTOs;

namespace Repository;

internal sealed class TokenRepository : RepositoryBase<AuthToken>, ITokenRepository
{
    private RepositoryContext _repositoryContext;
    public TokenRepository(RepositoryContext repositoryContext): base(repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public async Task<AuthToken> FindToken(RefreshTokenDTO tokens)
    {
        return await _repositoryContext.Set<AuthToken>().Include(t => t.User)
        .FirstOrDefaultAsync((t) => t.RefreshToken.Equals(tokens.RefreshToken) && t.AccessToken.Equals(tokens.Token));
    }
}