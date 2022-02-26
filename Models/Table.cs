using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GreatTables.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string Quality { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public String Color { get; set; }
        public string Measurements { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}