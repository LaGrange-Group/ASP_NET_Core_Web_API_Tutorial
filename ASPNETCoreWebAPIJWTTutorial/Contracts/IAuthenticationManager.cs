using ASPNETCoreWebAPIJWTTutorial.DataTransferObjects;
using System.Threading.Tasks;

namespace ASPNETCoreWebAPIJWTTutorial.Contracts
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserForAuthenticationDto userForAuth);
        Task<string> CreateToken();
    }
}
