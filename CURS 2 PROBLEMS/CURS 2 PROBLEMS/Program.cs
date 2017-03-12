using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS_2_PROBLEMS
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nc = 0, k = 0; int np=n;
            do {
                nc++;
                n = n / 10;
            } while (n != 0); int[] v = new int[nc]; n = np;
            k = nc-1;
            do{
                v[k]=n%10;
                n=n/10;
                k--;
            }while(n!=0);
            int[] c = new int[10];
            int nrmaxim = 0;
            for (int i = 0; i < 10; i++) c[i] = 0;
            for (int i = 0; i < 10; i++)
            {
                c[v[i]]++;
            }
            for (int i = 9; i >=0; i--)
            {
                nrmaxim = nrmaxim * 10 + i;
            }
            Console.WriteLine("Numar maxim="+nrmaxim);
            Console.ReadLine();
        }
    }
}
