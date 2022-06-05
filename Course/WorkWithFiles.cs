using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal static class WorkWithFiles
    {
        public static void OutputData(string nameOfFile, string function, List<List<double>> values)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nameOfFile))
                {
                    writer.WriteLine(function);
                    for (int i = 0; i < values[1].Count; i++)
                    {
                        writer.Write("X:" + values[0][i] + " Y:" + values[1][i] + "|");
                    }
                }
            }
            catch
            {
                return;
            }
            
        }

        public static string[] InputData(string path)
        {
            string[] result = new string[4];
            using (StreamReader reader = new StreamReader(path))
            {
                var dividedText = reader.ReadToEnd().Split('|');
                for (int i = 0; i < dividedText.Length; i++)
                {
                    result[i] = dividedText[i];
                }
            }
            return result;
        }
    }
}
