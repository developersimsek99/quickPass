using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace quickPassProject.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        [MinLength(8, ErrorMessage = "Şifre uzunluğunuz en az 8 karakter olmalıdır.")]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public Nullable<byte> IsAdmin { get; set; }
        [Required]
        public bool SecurityAndUse { get; set; }
        public bool UpdateAndAdv { get; set; }
        public string LoginErrorMessage { get; set; }
        public virtual bool RememberMe { get; set; }
    }
}