﻿using eCommerce.Core.Domain.DbEntities;
using System;
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
        /// Kullanıcı bul.
        /// </summary>
        /// <param name="confirmationId"></param>
        /// <returns></returns>
        User FindByConfirmationId(Guid confirmationId);

        /// <summary>
        /// Kullanıcı ekle.
        /// </summary>
        /// <param name="user"></param>
        void Insert(User user);

        /// <summary>
        /// Kullanıcı güncelle.
        /// </summary>
        /// <param name="user"></param>
        void Update(User user);

        /// <summary>
        /// Kullanıcı sil.
        /// </summary>
        /// <param name="user">Kullanıcı</param>
        void Delete(User user);

        /// <summary>
        /// Kullanıcı sil.
        /// </summary>
        /// <param name="userId">Kullanıcı Id</param>
        void Delete(int userId);

        /// <summary>
        /// Yeni üye olan kullanıcıya onay mesajı gönder.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="ConfirmationUrl"></param>
        /// <returns>Email send success status</returns>
        bool SendConfirmationMail(User user, string ConfirmationUrl);

        /// <summary>
        /// Eposta sistemde kayıtlı mı.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        bool ValidateEmail(string email);

        /// <summary>
        /// Kullanıcı adı sistemde kayıtlı mı.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        bool ValidateUserName(string userName);
    }
}
