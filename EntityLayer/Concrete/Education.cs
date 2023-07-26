using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Education
    {
        [Key]
        public int ID {  get; set; }

        [StringLength(50)]
        public string Heading { get; set; }
        [StringLength(150)]
        public string SubHead1 { get; set; }
        [StringLength (150)]
        public string SubHead2 { get; set; }
        [StringLength(50)]
        public string Average { get; set; }
        public DateTime Date { get; set; }




    }
}
