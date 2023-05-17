using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodDemo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool cont = true;
            string checkText = "";
            do
            {
                Console.WriteLine("Chon chuc nang:");
                Console.WriteLine("1. Nhap danh sach hoc vien");
                Console.WriteLine("2. Xuat danh sach hoc vien");
                int cn = int.Parse(Console.ReadLine());

                switch (cn)
                {
                    case 1:
                        {
                            NhapDanhSach(); 
                            break;
                        }
                    case 2:
                        {
                            XuatDanhSach();
                            break;
                        }
                    default:
                        Console.WriteLine($"Khong co chuc nang so {cn}"); break;
                }


                #region Hoi nguoi co tiep tuc hay khong?
                Console.WriteLine("Tiep tuc? (Y)");
                checkText = Console.ReadLine();
                if (checkText == "Y")
                {
                    cont = true;
                }
                else
                {
                    cont = false;
                }
                #endregion
            } while (cont == true);

            Console.WriteLine("ket thuc chuong trinh");
            Console.ReadLine();
        }

        static void NhapDanhSach()
        {
            // Cac cau lenh cho chuc nang duoc thuc hien o day
            Console.WriteLine("Chuc nang 1. Nhap danh sach hoc vien");
        }

        static void XuatDanhSach()
        {
            Console.WriteLine("Chuc nang 2. Xuat danh sach hoc vien");
        }

    }
}
