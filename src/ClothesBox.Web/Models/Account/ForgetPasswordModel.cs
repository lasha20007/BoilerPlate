using Abp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClothesBox.Web.Models.Account
{
    public class ForgetPasswordModel
    {
        [EmailAddress]
        public string Email { get; set; }

    }
}