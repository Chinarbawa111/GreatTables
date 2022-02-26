using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;


namespace GreatTables.Models
{
    public class GreatTables
    {
        public int Id { get; set; }
        public string Quality { get; set; }

        public String Color { get; set; }
        public string Measurements { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}