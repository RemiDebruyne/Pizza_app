﻿using Pizza_API.Validator;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pizza_API.DTOs
{
    public class UserDTO
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$", ErrorMessage = "Invalid email address")]
        public string Email { get; set; }


        [Required]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }


    }
}