using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Models.VisitorLog
{
    public partial class SecurityOfficer
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "Поле не должно быть пустым.")]

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Не меньше 4 и не больше 100 символов.")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым.")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Не меньше 4 и не больше 100 символов.")]
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
