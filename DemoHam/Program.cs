using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1. Tinh Tong");
                Console.WriteLine("2. Tinh hieu");
                int cn = int.Parse(Console.ReadLine());

                switch (cn)
                {
                    case 1:
                        {
                            TinhTong();
                            break;
                        }
                    case 2:
                        {
                            TinhHieu();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Khong co chuc nang {cn}");
                            break;
                        }
                }

                Console.WriteLine("Tiep tuc? (Nhap 'Y' de tiep tuc");
                string tt = Console.ReadLine();
                if (tt == "Y")
                {
                    cont = true;
                }
                else
                {
                    break;
                }

            } while (cont == true);

           
        }
        static void TinhTong()
        {
            Console.WriteLine("Chuc nang tinh tong");
            int a, b;
            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.ReadLine();
        }

        static void TinhHieu()
        {
            Console.WriteLine("Chuc nang tinh hieu");
            int a, b;
            Console.WriteLine("Nhap a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = int.Parse(Console.ReadLine());


            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.ReadLine();
        }

    }
}
