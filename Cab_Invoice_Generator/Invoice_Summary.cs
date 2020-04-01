using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Generator
{
    public class Invoice_Summary
    {
        Calculation_Fare calc_fare = new Calculation_Fare();
        /// <summary>
        /// It return the total ride
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public int Get_All_Rides(List<Ride> rides)
        {
            return rides.Count;
        }
        /// <summary>
        /// It return the total fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double Total_fare(List<Ride> rides)
        {
            return calc_fare.Calculate_multi_ride_fare(rides);
        }
        /// <summary>
        /// It return the total 
        /// Average fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double Average_fare_per_ride(List<Ride> rides)
        {
            return (calc_fare.Calculate_multi_ride_fare(rides)) / (rides.Count);
        }
    }
}
