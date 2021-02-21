using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace wwwKurumsal.Data
{
    public class Users
    {
        public int Id { get; set; }
        [DisplayName("E-Posta")]
        [Required(ErrorMessage = "Email alanı zorunludur")]
        public string Email { get; set; }
        [DisplayName("Şifre")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Şifre alanı zorunludur")]
        public string Password { get; set; }
        public string LoginErrorMessage { get; set; }
        public bool IsActive { get; set; } 
    }
}