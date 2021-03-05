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
            double bmi;
            {
                bmi = 703 * weight / (height * height);
            }
            return bmi;
        }

        /// <summary>
        /// Calculate BMR of  a Person
        /// </summary>
        /// <returns></returns>
        public static double CalculateBMR(string gender,double weight, double height, double age)
        {
            double bmr;
            if (gender.Equals("Male"))
            {
                bmr = 10 * weight + 6.25 * height - 5 * age + 5;
            }
            else
            {
                bmr = 9.247 * weight + 3.098 * height - 4.330 * age + 447.593;
            }
            return bmr;
        }


        /// <summary>
        /// Caculate body fat based upon person's Person's Height Weight ,neck size and abdomen size
        /// </summary>
        /// <returns></returns>
        public static double CalCulateFat(double abdomen, double neck, double height)
        {
            var part1 = 86.010 * Math.Log10(abdomen - neck);
            var part2 = 70.041 * Math.Log10(height);
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
            if (userHealth.UserProfile.Gender.Equals("Male"))
            {
                return 13.397 * (userHealth.Weight / 2.209) + 4.799 * (userHealth.Height * 2.54) - 5.677 * Convert.ToInt32(userHealth.UserProfile.Age) + 88.362;
            }
            else
            {
                return 10 * (userHealth.Weight / 2.209) + 6.25 * (userHealth.Height * 2.54) - 5 * Convert.ToInt32(userHealth.UserProfile.Age) - 161;
            }
        }
    }
}