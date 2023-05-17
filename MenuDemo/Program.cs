using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1. Cong");
                Console.WriteLine("2. Tru");
                Console.WriteLine("3. Nhan");
                Console.WriteLine("4. Chia");

                int cn = int.Parse(Console.ReadLine());

                switch (cn)
                {
                    case 1:
                        {
                            Cong();
                            break;
                        }
                    case 2:
                        {
                            Tru();
                            break;
                        }
                    case 3:
                        {
                            Nhan();
                            break;
                        }
                    case 4:
                        {
                            Chia();
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

        static void Cong()
        {
            Console.WriteLine("Chuc nang Cong");
        }

        static void Tru()
        {
            Console.WriteLine("Chuc nang Tru");
        }
        static void Nhan()
        {
            Console.WriteLine("Chuc nang Nhan");
        }
        static void Chia()
        {
            Console.WriteLine("Chuc nang Chia");
        }
    }
}
