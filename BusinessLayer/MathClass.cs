using System;

namespace MathLibrary
{
    public class MathClass
    {
        public int Sum(int n1, int n2)
        {
            if (n1 <= 0 && n2 <= 0)
            {
                throw new ArgumentException("No Zero or Negative are allowed");
            }
            else
            {
                return n1 + n2;
            }
        }
    }
}
