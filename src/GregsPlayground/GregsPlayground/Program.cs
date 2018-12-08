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
                if (args[i].Equals("Panda", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Panda's favorite food is bamboo.");
                }
            }
        }

        private static void PlayingWithExceptions(string exeptionName)
        {
            try
            {
                int y = int.Parse(exeptionName);
            }          
            catch (FormatException fe)
            {
                Console.WriteLine(exeptionName + " is not a number");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
