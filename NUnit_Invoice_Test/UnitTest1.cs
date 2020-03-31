using NUnit.Framework;
using Cab_Invoice_Generator;
using System.Collections.Generic;

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
          var actual=  calculate_fare.Calculate_Fare(5.0);
            Assert.AreEqual(50,actual);
        }

        /// <summary>
        /// This test method calculate the 
        /// multiride fare for single user
        /// </summary>
        [Test]
        public void Multi_Ride_Fare()
        {
            //It creates the List for multi ride .
            List<Ride> ls = new List<Ride>{ new Ride { distance_in_km = 12, time_in_min = 0 }, new Ride { distance_in_km = 0,time_in_min=55 } };
           var actual= calculate_fare.Calculate_multi_ride_fare(ls);
            Assert.AreEqual(175,actual);
        }
    }
}