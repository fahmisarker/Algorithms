using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class TextFileReader
    {
        public static int[] GetArray(string filePath)
        {
            var content = File.ReadAllText(filePath);
            string[] s = content.Split(new char[] { ' ' });
            int[] a = s.Select(p => int.Parse(p)).ToArray();
            return a;
        }
    }
}
