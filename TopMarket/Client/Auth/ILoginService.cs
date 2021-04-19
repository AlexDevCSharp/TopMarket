using TopMarket.Shared.DTOs;
using System.Threading.Tasks;

namespace TopMarket.Client.Auth
{
    public interface ILoginService
    {
        Task Login(UserToken userToken);
        Task Logout();
        Task TryRenewToken();
    }
}
