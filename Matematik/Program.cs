using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dortislem dortislem = new dortislem();
            dortislem.topla(5, 6);
            
            dortislem.topla(6, 9);
            Console.ReadKey();
        }

        
    }
}
