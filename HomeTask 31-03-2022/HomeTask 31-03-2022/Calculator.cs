using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_31_03_2022
{
 /*Static Calculator class-ı olsun. 

İki Int qəbul edib Int qaytaran Sum 
İki Int qəbul edib Int qaytaran Subtract

İki Int qəbul edib Int qaytaran Multiply

İki Int qəbul edib Int qaytaran Divide

Static Metodları olsun. Adlarına uyğun işi görsünlər.*/


    static class Calculator
    {
        public static int Sum(int a,int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("You can't divide by 0" );
                return -1;
            }
        }
        /*Int-lərə bir Power extension-u yazın. Rəqəm qəbul edib hansı intdən çağırılıbsa onu qəbul etdiyi rəqəm qüvvətinə qaldırıb qaytarsın.*/
        // taskın şərtini belə başa düşdüm ki 4 daxil eləsək 4^4 ,7 daxil eləsək 7^7 ni  və s. hesablasın

        public static int Power(this int a)
        {
            int result = 1;
            if (a > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    result *= a;
                }
                return result;
            }
            else 
            {
                a *= -1;
                for (int i = 0; i < a; i++)
                {
                    result *= a;
                }
                Console.Write("1/");
                return result;
            }
        }
    }
}
