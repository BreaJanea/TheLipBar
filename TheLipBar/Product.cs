﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TheLipBar
{
    public class Product
    {
        //private int iD;
        private string name;
        private double price;
        private string description;

        //public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }

        public Product(string name, double price, string description)
        {
           // this.iD = iD;
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public override string ToString()
        {
            return $"{name} - {price.ToString("C", CultureInfo.CurrentCulture)}";
        }
    }
}
