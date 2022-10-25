using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empwageday9
{
    internal class dailywage
    {
        public static void calwage()
        {
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(2);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is present");
                emphrs = 8;
            }
            else
            {
                Console.WriteLine("employee is absent");
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage:" + empwage);
        }
    }
}
