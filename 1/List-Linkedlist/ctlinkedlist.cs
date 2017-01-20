using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace List_Linkedlist
{

    class ctlinkedlist
    {
 
        public void linkedlist() {
            LinkedList<string> al = new LinkedList<string>();
            
            String s;
            int i = 0;
            int check;
            
           
            
            string x;
            Console.WriteLine("------------------ Ho Trong Anh------------------");
            Console.WriteLine("------------ KIEU DU LIEU LINKED LIST ------------");
            Console.WriteLine("");

            Console.WriteLine("  Nhap 1 chuoi cac day ki tu tu ban phim");
            Console.WriteLine("    (cac day ngan cach bang khoang trang)");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Chuoi truoc khi sap xep: ");
            Console.WriteLine(s);
           
            s = s.Trim();
            string[] b = s.Split(' ');
            int n = b.Length;
           
            {

                for (i = 0; i < n - 1; i++)

                    for (int k = i + 1; k < n; k++)

                        if (b[k].CompareTo(b[i]) == 0)
                        {

                            for (int j = k; j < n - 1; j++)

                                b[j] = b[j + 1];

                            n--;

                            k--;

                        }

            }
            Console.WriteLine("Chuoi sau khi luoc bo phan tu trung: ");
            for (i = 0; i <= n - 1; i++)
            {
                Console.Write(b[i] + " ");
            }
            int dem = n;
            



           

            al.AddFirst(b[0]);
            LinkedListNode<string> node = al.First;
            LinkedListNode<string> node2 = al.First;
            string m;
            
            
            for (i = 1; i < dem; i++)
            {
                m = (b[i].ToString());
                while (node != null)
                {
                    if (m.CompareTo(al.First.Value.ToString()) < 0)
                    {
                        al.AddFirst(b[i]);
                        break;
                    }
                    if (m.CompareTo(al.Last.Value.ToString()) > 0)
                    {
                        al.AddLast(b[i]);
                        break;
                    }
                    if ((m.CompareTo(node2.Value.ToString()) > 0) && (m.CompareTo(node2.Next.Value.ToString()) < 0))
                    {
                        // node = node.Next;
                        al.AddAfter(node2, b[i]);
                        break;
                    }
                    node2 = node2.Next;
                }
                node2 = al.First;

            }
           
  
            //Sap xep
           // al.Sort();
            //Truyen vao chuoi
            node = al.First;
            Console.WriteLine("");
            Console.WriteLine("Chuoi sau khi sap xep: ");
            while (node != null)
            {
                Console.Write(node.Value.ToString());
                Console.Write(" ");
                node = node.Next;
            }
            node = al.First;
            Console.WriteLine("");
            //Chen them so
            do
            {
                check = 0;
                Console.Write("Nhap chuoi ky tu muon them vao , x= ");
                x = Convert.ToString(Console.ReadLine());
                Console.WriteLine("");
                //Kiem tra xem x co trong list khong??
                while (node != null)
                {
                    if (x.CompareTo(node.Value.ToString())==0)
                    {
                        check = 1;
                        Console.WriteLine("chuoi x da ton tai trong day. Xin moi nhap lai!");
                    }
                   node = node.Next;
                }
                node = al.First;
            } while (check == 1);
           
            //
            node = al.First;

            while (node != null)
            {
                if (x.CompareTo(al.First.Value.ToString()) < 0)
                {
                    al.AddFirst(x);
                    break;
                }
                if (x.CompareTo(al.Last.Value.ToString()) > 0)
                {
                    al.AddLast(x);
                    break;
                }
                if ((x.CompareTo(node.Value.ToString()) > 0) && (x.CompareTo(node.Next.Value.ToString()) < 0))
                {
                    // node = node.Next;
                    al.AddAfter(node, x);
                    break;
                }
                 node = node.Next;
            }
            node = al.First;
            Console.WriteLine("Chuoi sau khi them va duoc sap xep: ");
            while (node != null)
            {
                Console.Write(node.Value.ToString());
                Console.Write(" ");
                node = node.Next;
            }
           // Console.WriteLine(al);
        }
    }
}
