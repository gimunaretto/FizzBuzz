using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Domain
{
    public class FizzBuzzCalculator
    {
        public String GetFizzBuzz(int i)
        {
            if (i == 0 || i % 15 == 0)
                return "FizzBuzz";
            else if (i != 0 && i % 3 == 0)
                return "Fizz";
            else if (i != 0 && i % 5 == 0)
                return "Buzz";

            return i.ToString();
        }
    }
}