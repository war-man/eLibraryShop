﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eLibraryShop.Models
{
    public class UserEdit
    {
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }


        [EmailAddress(ErrorMessage = "Wprowadź poprawny adres email")]
        public string Email { get; set; }


        [MinLength(6, ErrorMessage = "Hasło musi zawierać minimum 6 znaków")]
        [DataType(DataType.Password, ErrorMessage = "Wprowadź poprawne hasło")]
        [Display(Name = "Nowe hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Wprowadź poprawne hasło")]
        [Compare("Password", ErrorMessage = "Hasła muszą być identyczne")]
        [Display(Name = "Powtórz hasło")]
        public string RepeatPassword { get; set; }

        [DataType(DataType.Password, ErrorMessage = "Wprowadź poprawne hasło")]
        [Display(Name = "Stare hasło")]
        public string OldPassword { get; set; }


        public UserEdit()
        {

        }

        public UserEdit(AppUser appUser)
        {
            UserName = appUser.UserName;
            Email = appUser.Email;
            Password = appUser.PasswordHash;
        }
    }
}