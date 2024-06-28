using Entities;
using Shared.DTOs.UserDTOs;

namespace Contracts.RepositoryContracts;

public interface ITokenRepository : IRepositoryBase<AuthToken>
{
    public Task<AuthToken> FindToken(RefreshTokenDTO tokens); 
}