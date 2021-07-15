using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime AddedTime { get; set; }
        public int StockIn { get; set; }
    }
}