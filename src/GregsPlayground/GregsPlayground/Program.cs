using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GregsPlayground
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("No file name entered.");
            }

            string fileName = args[0];

            for (int i = 1; i < args.Length; i++)
            {
                WriteToFile(fileName, args[i]);
            }

        }

        private static void WriteToFile(string pathToFile, string line)
        {
            StreamWriter writer = new StreamWriter(pathToFile, true);
            writer.WriteLine(line);
            writer.Close();
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

        private static void Compare(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Equals("Panda", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Panda's favorite food is bamboo.");
                }
            }
        } 
    }
}
