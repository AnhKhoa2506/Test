using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timkiemnhiphan
{
    internal class Program
    {
        /*static void ReplaceValues(int[] A, int oldValue, int newValue)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == oldValue)
                {
                    A[i] = newValue;
                }
            }
        }*/
        static int Bseach(int[]A, int l, int r, int x)
        {
            if (l <= r)
            {
                int mid = (l + r) / 2;
                if (A[mid] == x) return mid;
                else if (A[mid] > x)
                {
                    return Bseach(A,l , mid - 1, x);
                }
                else return Bseach(A, mid + 1,r, x);
            }
            else return -1;
        }
        static int timkiem(int[]A, int x)
        {
            for (int i = 0; i < A.Length; i++)
            {
                if (x == A[i]) return i;
                
            
            }return -1;
        }
       /* static void thaythe(int[]A, int x)
        {
            foreach (int num in A)
            {
                if (num == num)
                {
                    Console.WriteLine("Thay the gia tri trung lap = ");
                    int c = int.Parse(Console.ReadLine());
                }
            }
        }*/
        static void Main(string[] args)
        {
            int[] A = null;
            Console.Write("Nhap do dai mang: ");
            int n = int.Parse(Console.ReadLine());
            A = new int[n]; 
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                A[i] = r.Next(30);
            }
           
            Array.Sort(A);
            Console.WriteLine("Cac gia tri co trong mang la: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("\t{0}", A[i]);
            }
    
            Console.WriteLine("\nNhap gia tri can tim: ");
            int x = int.Parse(Console.ReadLine());
            int vitri = Bseach(A, 0, n - 1, x);
            if (vitri != -1)
            {
                Console.WriteLine("Gia tri tim duoc nam o {0}", timkiem(A,x));
            }
            else Console.WriteLine("Gia tri ko co trong mang A");
            Console.Read();



        }
    }
}
