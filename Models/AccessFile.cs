using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    [Table("Details")]
    public class AccessFile
    {
           [Key]
            public string Category { get; set; }
            public int Year { get; set; }
            public int Amount { get; set; }

    }
}