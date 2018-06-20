using System;
namespace GeometricalTaskII
{
    class Program
    {
        static void Main()
        {
            string[] n = Console.ReadLine().Split();
            double tmp = double.Parse(n[1]);
            double ans;
            string a;
            if (n.Length == 2)
            {               
                ans = Math.Round(tmp * tmp * 3.14,2);
                a = ans.ToString();
                if (ans * 10 % 10 == 0)
                    a += ".0";
                if (ans * 100 % 10 == 0)
                    a += "0";
                Console.WriteLine(a);               
            }
            else
            {                
                double tmp1 = double.Parse(n[2]);
                ans = Math.Round(tmp * tmp1 / 2, 2);
                a = ans.ToString();
                if (ans * 10 % 10 == 0)
                    a += ".0";
                if (ans * 100 % 10 == 0)
                    a += "0";
                Console.WriteLine(a);               
            }            
        }
    }
}
