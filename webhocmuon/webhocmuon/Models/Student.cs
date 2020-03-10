using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webhocmuon.Models
{
    public class Student
    
    {
        public int Id { get; set; }
        public string RollNumber { get; set; }
        public Options PenaltyOption { get; set; }
        [Range(0, 1000000)]
        public double Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime CurrentDateTime { get; set; }

    }
    public enum Options
    {
        payment,
        pushUp
    }
}