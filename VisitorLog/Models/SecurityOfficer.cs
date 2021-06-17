using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.VisitorLog
{
    public partial class SecurityOfficer
    {
        public int Id { get; set; }
        [Range(4, 100, ErrorMessage = "Должно быть как минимум 4 символа")]
        public string Login { get; set; }
        [Range(4, 100, ErrorMessage = "Должно быть как минимум 4 символа")]
        public string Password { get; set; }

        //public SecurityOfficer(int id, string login, string password)
        //{
        //    Id = id;
        //    Login = login;
        //    this.password = password;
        //}

        //public void ChangePassword(string oldPassword, string newPassword)
        //{
        //    if (password != oldPassword)
        //        throw new Exception();
        //    password = newPassword;
        //}
    }
}
