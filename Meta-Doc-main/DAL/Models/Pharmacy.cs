using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Pharmacy
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Location { get; set; }
        [Required]
        public string Role { get; set; }
        //[ForeignKey("User")]
        //public int User_Id { get; set; }
        //public virtual User Users { get; set; }
    }
}
