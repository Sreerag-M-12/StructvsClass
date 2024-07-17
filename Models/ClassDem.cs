using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructvsClassDemo.Models
{
    internal class ClassDem
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Id { get; set; }



        public ClassDem(string brand, string model, string color) 
        {
            Brand = brand;
            Model = model;
            Color = color;
        }

        public ClassDem(int id) 
        { 
            Id = id;
        }
    }
}
