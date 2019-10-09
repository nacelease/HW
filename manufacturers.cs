using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace llllllcars.Data
{
    public class manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MID { get; set; }
        [Display(Name ="Manufacturers Name")]
        public string Mname { get; set; }
        [Display(Name ="Manufacturers Type")]
        public string Mtype { get; set; }
    }
}
