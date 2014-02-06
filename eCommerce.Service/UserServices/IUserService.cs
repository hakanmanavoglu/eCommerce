using eCommerce.Core.Domain.DbEntities;
namespace eCommerce.Service.UserServices
{
    public interface IUserService
    {
        /// <summary>
        /// Kullanıcı bul.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        User FindByUserNameAndPassword(string userName, string password);
    }
}
