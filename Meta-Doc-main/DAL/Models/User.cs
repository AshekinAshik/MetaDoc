﻿//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL.Models
//{
//    public class User
//    {
//        [Key]
//        public int Id { get; set; }
//        [Required]
//        public string Username { get; set; }
//        [Required]
//        public string Password { get; set; }
//        [Required]
//        public string Role { get; set; }

//        public virtual Admin Admin { get; set; }
//        public virtual Doctor Doctor { get; set; }
//        public virtual Patient Patient { get; set; }
//        public virtual Pharmacy Pharmacy { get; set; }
//    }
//}