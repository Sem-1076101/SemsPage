using PortfolioApi.DTO;

namespace PortfolioApi.Services {
    public interface IAuthService {
        Task<bool> Register(RegisterDto request);
        Task<string?> LoginAsync(LoginDto request);
    }
}