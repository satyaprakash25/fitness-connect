using System;
using System.Collections.Generic;
using System.Text;

namespace GL.FC.Shared
{
    public static class HealthUtility
    {
        /// <summary>
        /// calculate Person's BMI based on Height and Weight of a person
        /// </summary>
        /// <returns></returns>
        public static double CalculateBMI(double weight, double height)
        {
            double Weighttous = 2.205 * weight;
            double heighttous = 0.0328084 * height * 12;
            double bmi;
            {
                bmi = 703 * Weighttous / (heighttous * heighttous);
            }
            return bmi;
        }

        /// <summary>
        /// Calculate BMR of  a Person
        /// </summary>
        /// <returns></returns>
        public static double CalculateBMR(string gender, double weight, double height, double age)
        {
            double Weighttous = 2.205 * weight;
            double heighttous = 0.0328084 * height * 12;
            double bmr;
            if (gender.Equals("Male"))
            {
                bmr = 10 * Weighttous + 6.25 * heighttous - 5 * age + 5;
            }
            else
            {
                bmr = 9.247 * Weighttous + 3.098 * heighttous - 4.330 * age + 447.593;
            }
            return bmr;
        }


        /// <summary>
        /// Caculate body fat based upon person's Person's Height Weight ,neck size and abdomen size
        /// </summary>
        /// <returns></returns>
        public static double CalCulateFat(double abdomen, double neck, double height)
        {
            double abdomenToUs = 0.0328084 * abdomen * 12;
            double neckToUs = 0.0328084 * neck * 12;
            double heighttous = 0.0328084 * height * 12;

            var part1 = 86.010 * Math.Log10(abdomenToUs - neckToUs);
            var part2 = 70.041 * Math.Log10(heighttous);
            return part1 - part2 + 36.76;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="P"></param>
        /// <param name="myfunc"> please provice mybodyfat function</param>
        /// <returns>Total Calories in the Calories</returns>
        public static double CalculateCalories(UserHealthModel userHealth)
        {
            double Weighttous = 2.205 * userHealth.Weight;
            double heighttous = 0.0328084 * userHealth.Height * 12;
            if (userHealth.UserProfile.Gender.Equals("Male"))
            {
                return 13.397 * (Weighttous / 2.209) + 4.799 * (heighttous * 2.54) - 5.677 * Convert.ToInt32(userHealth.UserProfile.Age) + 88.362;
            }
            else
            {
                return 10 * (Weighttous / 2.209) + 6.25 * (heighttous * 2.54) - 5 * Convert.ToInt32(userHealth.UserProfile.Age) - 161;
            }
        }

        public static double IdealWeight(double height, double weight, string gender)
        {
            double heighttous = 0.0328084 * height * 12;
            if (gender.Equals("Male"))
                return 110.231 + 5.07063 * (heighttous - 60);
            else
                return 100.3103 + 5.07063 * (heighttous - 60);
        }
    }
}