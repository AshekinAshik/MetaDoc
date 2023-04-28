﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Order")]
        public int Order_Id { get; set; }
        [ForeignKey("Pharmacy")]
        public int Pharmacy_Id { get; set; }
        [ForeignKey("Patient")]
        public int Patient_Id { get; set; }

        public virtual Pharmacy Pharmacies { get; set; }
        public virtual Patient Patients { get; set; }
        public virtual Order Orders { get; set; }
    }
}
