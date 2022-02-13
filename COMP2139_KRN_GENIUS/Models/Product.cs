﻿using System.ComponentModel.DataAnnotations;

namespace COMP2139_KRN_GENIUS.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Please enter the code")]
        public string? Code { get; set; }

        [Required(ErrorMessage = "Please enter the name of the product")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter the price")]
        public double? YearlyPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
