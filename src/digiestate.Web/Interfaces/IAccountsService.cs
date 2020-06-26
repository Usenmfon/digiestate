using System.Threading.Tasks;
using digiestate.Data.Entities;
using digiestate.Web.Models;

namespace digiestate.Web.Interfaces
{
    public interface IAccountsService
    {
        Task<ApplicationUser> CreateUserAsync(RegisterModel model);
    }
}