using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasha_comp_num
{
    class Program
    {
        class comp_num
        {
            double real;
            double imaginary;
            public comp_num(double real = 0, double imaginary = 0)
            {
                this.real = real;
                this.imaginary = imaginary;
            }
            public void Show()
            {
                Console.WriteLine("{0}+{1}*i", real, imaginary);
            }
            public comp_num add_Complex(comp_num y)
            {
                return new comp_num(this.real + y.real, this.imaginary + y.imaginary);
            }
            public static comp_num subs(comp_num x, comp_num y)
            {
                return new comp_num(x.real - y.real, x.imaginary - y.imaginary);
            }
            public static comp_num operator *(comp_num x, comp_num y)
            {
                return new comp_num(x.real * y.real - x.imaginary * y.imaginary, x.real * y.imaginary + x.imaginary * y.real);
            }
        }
        static void Main(string[] args)
        {
            comp_num z = new comp_num(4, 6);
            comp_num u = new comp_num(3,5);
            comp_num s;
            s = z * u;
            Console.WriteLine("умножение");
            s.Show();
            Console.WriteLine("отнимание");
            comp_num o = comp_num.subs(z, u);
            o.Show();
            Console.WriteLine("суммирование");
            comp_num c =  z.add_Complex(u);
            c.Show();
            Console.ReadKey();


        }
    }
}
