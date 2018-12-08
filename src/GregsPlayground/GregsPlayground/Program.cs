using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregsPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {
                Console.Write(i);
                Console.WriteLine(args[i]);
            }
        }
    }
}
