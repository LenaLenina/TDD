using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoRental;

namespace UsingVideoRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Alex");
            customer.Rentals.Add(new Renatal(Movie.RegularMovie("Movie1"), 6));
            customer.Rentals.Add(new Renatal(Movie.NewReleaseMovie("Movie2"), 2));

            ReportManager.CreateSimpleReport(@"D:\\VideoRentalTest\\TestReport.txt", customer);
        }
    }
}
