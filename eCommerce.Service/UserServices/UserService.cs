using eCommerce.Core.Domain.DbEntities;
using eCommerce.Data.Repositories;
using eCommerce.Data.UnitOfWork;
using System.Linq;
using System.Net.Mail;
namespace eCommerce.Service.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<User> _userRepository;

        public UserService(IUnitOfWork uow)
        {
            _uow = uow;
            _userRepository = uow.GetRepository<User>();
        }

        /// <summary>
        /// Kullanıcı bul.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User FindByUserNameAndPassword(string userName, string password)
        {
            return _userRepository.GetAll().FirstOrDefault(x => x.UserName == userName && x.Password == password);
        }

        /// <summary>
        /// Kullanıcı ekle.
        /// </summary>
        /// <param name="user"></param>
        public void Insert(User user)
        {
            _userRepository.Insert(user);
        }

        /// <summary>
        /// Yeni üye olan kullanıcıya onay mesajı gönder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ConfirmationUrl"></param>
        /// <returns>Email send success status</returns>
        public bool SendConfirmationMail(User user, string ConfirmationUrl)
        {
            var status = false;
            string confirmationId = user.ConfirmationId.ToString();
            ConfirmationUrl += "/Account/ConfirmUser?confirmationId=" + confirmationId;

            var message = new MailMessage("alirizaadiyahsi@gmail.com", user.Email)
            {
                Subject = "Lütfen e-posta adresinizi onaylayınız.",
                Body = ConfirmationUrl
            };

            var client = new SmtpClient();
            try
            {
                client.Send(message);
                status = true;
            }
            catch (System.Exception)
            {
                return status;
            }

            return status;
        }
    }
}
