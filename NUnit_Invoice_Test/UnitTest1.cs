using NUnit.Framework;
using Cab_Invoice_Generator;
using System.Collections.Generic;
using System.Linq;

namespace NUnit_Invoice_Test
{
    /// <summary>
    /// This is a test method for
    /// cab invoice generator
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// It creates the object of Calculate class fare
        /// </summary>
        Calculation_Fare calculate_fare = new Calculation_Fare();
        Invoice_Summary invoice_Summary = new Invoice_Summary();
        RideRepository ride_repository = new RideRepository();

        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// This  Test method calculate the 
        /// simple fare 
        /// </summary>
        [Test]
        public void Single_Ride_Fare()
        {
            var actual = calculate_fare.Calculate_Fare(5.0);
            Assert.AreEqual(50, actual);
        }

        /// <summary>
        /// This test method calculate the 
        /// multiride fare for single user
        /// </summary>
        [Test]
        public void Multi_Ride_Fare()
        {
            //It creates the List for multi ride .
            List<Ride> ls = new List<Ride> { new Ride { distance_in_km = 12, time_in_min = 0 }, new Ride { distance_in_km = 0, time_in_min = 55 } };
            var actual = calculate_fare.Calculate_multi_ride_fare(ls);
            Assert.AreEqual(175, actual);
        }

        /// <summary>
        /// It Calculate the total number 
        /// of rides  and return it .
        /// </summary>
        [Test]
        public void Total_number_of_Ride()
        {
            List<Ride> l_rides = new List<Ride>();
            l_rides.Add(new Ride { distance_in_km = 25, time_in_min = 5 });
            l_rides.Add(new Ride { distance_in_km = 0, time_in_min = 56 });
            l_rides.Add(new Ride { distance_in_km = 20, time_in_min = 65 });
            l_rides.Add(new Ride { distance_in_km = 25, time_in_min = 0 });
            Assert.AreEqual(invoice_Summary.Get_All_Rides(l_rides), l_rides.Count());
        }

        /// <summary>
        ///  It calculate the Total fare of 
        ///  Total ride and return it .
        /// </summary>
        [Test]
        public void Get_Total_Fare()
        {
            List<Ride> ls = new List<Ride> { new Ride { distance_in_km = 190, time_in_min = 0 }, new Ride { distance_in_km = 0, time_in_min = 55 } };
            Assert.AreEqual(1955.0, invoice_Summary.Total_fare(ls));
        }

        /// <summary>
        /// It calculate the Average fare of 
        /// multi ride and return it .
        /// </summary>
        [Test]
        public void Get_Average_fare()
        {
            List<Ride> list_rides = new List<Ride>();
            list_rides.Add(new Ride { distance_in_km = 55, time_in_min = 85 });
            list_rides.Add(new Ride { distance_in_km = 0, time_in_min = 95 });
            list_rides.Add(new Ride { distance_in_km = 755, time_in_min = 0 });
            Assert.AreEqual(2760.0, invoice_Summary.Average_fare_per_ride(list_rides));
        }

        /// <summary>
        /// It return total rides of any user
        /// by it's id .
        /// </summary>
        [Test]
        public void Get_User_Rides_Count_by_User_Id()
        {
            List<Ride> list_rides = new List<Ride>();
            list_rides.Add(new Ride { distance_in_km = 55, time_in_min = 85 });
            list_rides.Add(new Ride { distance_in_km = 0, time_in_min = 95 });
            list_rides.Add(new Ride { distance_in_km = 755, time_in_min = 0 });
            ride_repository.Add_Rides("12345", list_rides);
            Assert.AreEqual(3, ride_repository.Get_User_Rides("12345"));
        }
    }
}