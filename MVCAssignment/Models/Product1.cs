using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAssignment.Models
{
    public class Product1
    {
        [Required()]
        public int pid { get; set; }
        [MaxLength(10, ErrorMessage = "Name cannot be greater than 10 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 character")]
        public string pname { get; set; }
        public int Cost { get; set; }



        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime Mfg_Date { get; set; }
    }
}