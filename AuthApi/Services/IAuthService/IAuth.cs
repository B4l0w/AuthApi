using AuthApi.Models.Dto;

namespace AuthApi.Services.IAuthService
{
    public interface IAuth
    {
        Task<string> Register(CreateUserDto createUserDto);
    }
}
