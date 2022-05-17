using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODMayExam2022
{
    public enum RentalType { House, Flat, Share}
    class RentalProperty
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
