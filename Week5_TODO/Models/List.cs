﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week5_TODO.Models
{
    public class List
    {
        [Key]
        public int ID { get; set; }
        public string ListName { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}