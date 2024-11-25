using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Demo02Calculatrice
{
    public static class Math
    {
        public static double add(double num1, double num2) => num1 + num2;

        public static double substract(double num1, double num2) => num1 - num2;

        public static double multiply(double num1, double num2) => num1 * num2;

        public static double divide(double num1, double num2)
        {
            if(num2 == 0)
                throw new DivideByZeroException();

            return num1 / num2;
        }
    }
}
