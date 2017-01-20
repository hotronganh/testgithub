using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
        Home:
            Console.WriteLine("--------Ho Trong Anh--------");
            Console.WriteLine("-----LIST/LINKED LIST------");
            Console.WriteLine("");
            Console.WriteLine("Chon kieu cau truc du lieu xu li");
            Console.WriteLine("  1.List");
            Console.WriteLine("  2.Linked List");
            Console.WriteLine("  3.Thoat");
            string choise = Convert.ToString(Console.ReadLine());

            if (choise.CompareTo("1") == 0)
            {
                ctlist x1 = new ctlist();
                x1.list();
                Console.WriteLine("");
                goto Home;
            }
            else
            {
                if (choise.CompareTo("2") == 0)
                {
                    ctlinkedlist x2 = new ctlinkedlist();
                    x2.linkedlist();
                    Console.WriteLine("");
                    goto Home;
                }
                else
                {
                    if (choise.CompareTo("3") == 0)
                    {
                        Console.WriteLine("Hen ban tro lai chuong trinh ^.^\n\t Bye!!!!");
                        goto Thoat;
                    }
                    else
                    {
                        Console.WriteLine("Lua chon khong hop le! Yeu cau chon lai");
                        Console.WriteLine("");
                        goto Home;
                    }

                }
            Thoat:
                Console.ReadLine();
            }
        }
    }
}
