﻿using System;

namespace Petshop.Core.Entity
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime SoldDate { get; set; }
        public string Colour { get; set;}
        public double Price { get; set; }
        public string PreviousOwner { get; set; }
    }
}
