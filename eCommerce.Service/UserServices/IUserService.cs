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

        /// <summary>
        /// Kullanıcı ekle.
        /// </summary>
        /// <param name="user"></param>
        void Insert(User user);

        /// <summary>
        /// Yeni üye olan kullanıcıya onay mesajı gönder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ConfirmationUrl"></param>
        /// <returns>Email send success status</returns>
        bool SendConfirmationMail(User user, string ConfirmationUrl);
    }
}
