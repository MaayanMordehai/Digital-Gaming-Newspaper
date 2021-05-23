﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DGN.Models
{
    public enum UserRole
    {
        Client, 
        Author,
        Admin
    }

    public class User
    {
        // Primery key
        public int Id { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [ForeignKey("Password")]
        public int PasswordId { get; set; }

        [Required]
        public Password Password { get; set; }

        [Required]
        [DisplayName("First name")]
        [MinLength(2)]
        [RegularExpression(@"^[A-Z\d].*$", ErrorMessage = "A name must begin with a capital letter.")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        [MinLength(2)]
        [RegularExpression(@"^[A-Z\d].*$", ErrorMessage = "A name must begin with a capital letter.")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        public UserRole Role { get; set; }


        [DisplayName("The Profile Image Location")]
        public string ImageLocation { get; set; }

        [DisplayName("Basic info about the user")]
        [DataType(DataType.MultilineText)]
        public string About { get; set; }

        // Shouldn't display in the form.
        public IList<Article> ArticleLikes { get; set; }

        // this is one to many with articles the user wrote
        // Shouldn't display in the form.
        public IList<Article> Articles { get; set; }
    }
}