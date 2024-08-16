using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class MathC
    {
        public int A {  get; set; }
        public int B {  get; set; }
        public MathC()
        {
            A = 0;
            B= 0;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Math Error! Divide by zero");
            }
            return (double)a / b;
        }
    }


}
