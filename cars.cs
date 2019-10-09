using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace llllllcars.Data
{
    public class cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CID { get; set; }

        public string color { get; set; }
        public float year { get; set; }
        [ForeignKey("MID")]
        public manufacturers manuID { get; set; }
    }
}
