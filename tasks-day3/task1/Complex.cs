using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Complex
    {
        int real;
        int img;
        public static int counter;
        public Complex()
        {
            counter++;
            real = img = 0;
            Console.WriteLine("Complex default ctor");
        }
        public Complex(int _real, int _img)
        {
            real = _real; img = _img;
            Console.WriteLine("Complex 2p ctor");
        }
        public Complex(int _num)
        {
            real = img = _num;
            Console.WriteLine("Complex 1p ctor");
        }

        public void setReal(int _real)
        {
            real = _real;
        }
        public int getReal()
        {
            return real;
        }
        public void setImg(int _img)
        {
            img = _img;
        }
        public int getImg()
        {
            return img;
        }
        public string Print()
        {
            {
                if (real == 0 && img == 0)
                {
                    return "0";
                }
                else if (real == 0)
                {
                    if (img == 1)
                    {
                        return "i";
                    }
                    else if (img == -1)
                    {
                        return "-i";
                    }
                    else
                    {
                        return $"{img}i";
                    }
                }
                else if (img == 0)
                {
                    return $"{real}";
                }
                else
                {
                    if (img == 1)
                    {
                        return $"{real}+i";
                    }
                    else if (img == -1)
                    {
                        return $"{real}-i";
                    }
                    else if (img > 0)
                    {
                        return $"{real}+{img}i";
                    }
                    else
                    {
                        return $"{real}{img}i";
                    }
                }
            }
        }

    //public Complex Add(Complex left, Complex right)
    //{
    //    Complex res = new Complex();
    //    res.real = left.real + right.real;
    //    res.img = left.img + right.img;
    //    return res;
    //}
    public Complex Add(/*caller,*/Complex right)
    {
        Complex res = new Complex();
        res.real = /*caller*/real + right.real;
        res.img = /*caller*/img + right.img;
        return res;
    }

}
}
