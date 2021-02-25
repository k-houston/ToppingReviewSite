﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Models
{
    public class Toppings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVegetarian { get; set; }
        public string Img { get; set; } = "Default.png";

        public virtual ICollection<Review> Reviews { get; set; }

        public Toppings()
        {

        }

        public Toppings(int id, string name, string description, bool isVegetarian)
        {
            Id = id;
            Name = name;
            Description = description;
            IsVegetarian = isVegetarian;
        }

    }
}
