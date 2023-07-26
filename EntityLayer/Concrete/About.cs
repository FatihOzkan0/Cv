using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(150)]
        public string Address { get; set; }
       
        [StringLength(50)]
        public string Phone  { get; set; }

        [StringLength(150)]
        public string Mail { get; set; }
        
        [StringLength(500)]
        public string Description { get; set; }
        
        [StringLength(300)]
        public string Image { get; set; }


    }
}
