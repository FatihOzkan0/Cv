﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Communication
    {
        [Key]
        public int ID { get; set; }
        
        [StringLength(100)]
        public string NameSurname { get; set; }
        
        [StringLength(100)]
        public string Mail { get; set; }
        
        [StringLength(50)]
        public string Subject { get; set; }
        
        [StringLength(500)]
        public string Message { get; set; }
        public DateTime Date { get; set; }


    }
}