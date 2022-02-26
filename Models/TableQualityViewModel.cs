using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GreatTables.Models
{
    public class TableQualityViewModel
    {
        public List<Table> Tables { get; set; }
        public SelectList Quality { get; set; }
        public string TableQuality { get; set; }
        public string SearchString { get; set; }
    }
}