using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Generator
{
    /// <summary>
    ///  This class is used for 
    ///  calculating the  fare
    /// of cab
    /// </summary>
    public class Calculation_Fare
    {
        /// <summary>
        /// Instance varriable 
        /// </summary>
        int cost_per_km = 10;
        int time_min;
        RideRepository ride_repo = new RideRepository();
        /// <summary>
        /// Its calculate the total fare of simple ride
        /// and return the fare
        /// </summary>
        /// <param name="_distance_in_km"></param>
        /// <param name="_time_in_min"></param>
        /// <returns></returns>
        public double Calculate_Fare(double _distance_in_km = 0, int _time_in_min = 0)
        {
            double total_fare = 0;
            total_fare = _distance_in_km * cost_per_km + _time_in_min * 1;
            if (total_fare < 5)
            {
                total_fare = 5;
            }
            return total_fare;
        }

        /// <summary>
        /// It calculate the multi ride fare of cab
        /// return the total fare
        /// </summary>
        /// <param name="rides"></param>
        /// <returns></returns>
        public double Calculate_multi_ride_fare(List<Ride> rides)
        {
            double total_fare = 0;
            foreach (Ride ride in rides)
            {
                total_fare += this.Calculate_Fare(ride.distance_in_km, ride.time_in_min);

            }

            return total_fare;
        }

        /// <summary>
        /// It add the specific user ride 
        /// with theire rides
        /// </summary>
        /// <param name="_user_id"></param>
        /// <param name="rides"></param>
        public void Add_Rides(string _user_id, List<Ride> rides)
        {
            ride_repo.AddRides(_user_id, rides);
        }
        /// <summary>
        /// It return the total count of any 
        /// added user rides .
        /// </summary>
        /// <param name="_user_id"></param>
        /// <returns></returns>
        public int Get_Rides_Count(string _user_id)
        {
            return ride_repo.Get_User_Rides(_user_id);

        }
    }
}
