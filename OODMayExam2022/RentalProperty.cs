using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OODMayExam2022
{
    //Enum
    public enum RentalType { House, Flat, Share}
    public class RentalProperty
    {
        //Properties
        public int ID { get; set; }
        public string Location { get; set; }
        public RentalType  TypeOfRental { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Constructors

        //Methods
        public void IncreaseRentByPercentage(decimal amountToIncrease)
        {
            //how make percentage???
            Price += amountToIncrease;
        }

        public override string ToString()
        {
            return Location;
        }
    }
    //END OF RENTAL PROPERTY CLASS

    public class RentalData : DbContext
    {
        public RentalData() : base("MyRentalData1234") { }

        public DbSet<RentalProperty> Rentals { get; set; }
    }

}
