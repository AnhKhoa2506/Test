using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dethimau_bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xi, yi;
            int xm, ym;
            int r;
            double im;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Đây là chương trình xác định vị trí điểm M ");
            Console.WriteLine("Nhập tọa độ tâm I: ");
            Console.Write("Hoành độ: ");
            xi = int.Parse(Console.ReadLine());
            Console.Write("Tung độ: ");
            yi = int.Parse(Console.ReadLine());
            Console.Write("Bán kính r = ");
            r = int.Parse(Console.ReadLine());
            Console.WriteLine("Tâm I ({0}, {1}) , R = {2}",xi,yi,r );
            Console.WriteLine("Nhập tọa độ điểm M");
            Console.Write("Hoành độ: ");
            xm = int.Parse(Console.ReadLine());
            Console.Write("Tung độ: ");
            ym = int.Parse(Console.ReadLine());
            im = Math.Sqrt(Math.Pow(xm - xi,2) + Math.Pow(ym-yi,2));
            Console.WriteLine("Độ dài IM = {0}", im);
            if ( im > r )
            {
                Console.WriteLine("Điểm M nằm ngoài đường tròn ");
            }
            else if ( im < r ) 
            {
                Console.WriteLine("Điểm M nằm trong đường tròn ");
            }
            else
            {
                Console.WriteLine("Điểm M nằm trên đường tròn ");
            }
            Console.Read();
        }
    }
}
