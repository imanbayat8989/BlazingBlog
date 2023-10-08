﻿using System.ComponentModel.DataAnnotations;

namespace BlazingBlog.Models
{
	public class LoginModel
	{
        [Required, EmailAddress,DataType(DataType.EmailAddress)]
        public string UserName { get; set; }
        [Required, MinLength(5)]
        public string Password { get; set; }
    }
}
