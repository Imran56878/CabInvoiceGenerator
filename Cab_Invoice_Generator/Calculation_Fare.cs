﻿using System;
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
    }
}
