using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace List_Linkedlist
{
    class ctlist
    {
        public void list()
        {
            List<string> al = new List<string>();
            String s;
            int i = 0;
            string x;
            int check;
            Console.WriteLine("--------------Ho Trong Anh-------------");
            Console.WriteLine("------------ KIEU DU LIEU LIST ------------");
            Console.WriteLine("");
            Console.WriteLine("  Nhap 1 chuoi  day ki tu vao tu ban phim");
            Console.WriteLine("    (cac day so ngan cach bang khoang trang)");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Chuoi truoc khi sap xep: ");
            Console.WriteLine(s);

            s = s.Trim();
            
            //string m;
            string[] b = s.Split(' ');
            int n = b.Length;
            {

                for ( i = 0; i < n - 1; i++)

                    for (int k = i + 1; k < n; k++)

                        if (b[k].CompareTo(b[i])==0)
                        {

                            for (int j = k; j < n - 1; j++)

                                b[j] = b[j + 1];

                            n--;

                            k--;

                        }

            }
            Console.WriteLine("Chuoi sau khi luoc bo phan tu trung: ");
            for (i = 0; i <= n-1; i++)
            {
                Console.Write(b[i] + " ");
            }

            int dem = n;
            for (i = 0; i <= dem - 1; i++)
            {
              //  m = string.Parse(b[i].ToString());
                al.Add(b[i]);
                n++;

            }
            //Sap xep
            al.Sort();
            //Truyen vao chuoi
            Console.WriteLine("");
            Console.WriteLine("Chuoi sau khi sap xep: ");
            foreach (string j in al)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine("");
            //Chen them so
            do{
                check = 0;
            Console.Write("Nhap day muon them vao day, x= ");
            x = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            //Kiem tra xem x co trong list khong??
            for (i = 0; i < al.Count; i++) {
                if (x == Convert.ToString(al[i]))
                {
                    check = 1;
                    Console.WriteLine("So x da ton tai trong chuoi. Xin moi nhap lai!");
                }
            }
            }while(check==1);
            Console.WriteLine("------------------------");
            al.Add(x.ToString());
            al.Sort();
   
            Console.WriteLine("Chuoi sau khi them va duoc sap xep: ");
            foreach (string j in al)
            {
                Console.Write(j + " ");
            }
        }
    }
}
