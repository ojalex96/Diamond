using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Diamond
{
    public class Program
    {
        public static void Main()
        {
            List<String> diamondList = DisplayDiamond(charc: 'z');
            foreach(var item in diamondList)
            {
                Console.WriteLine(item);
            }
        }
        public static List<String> DisplayDiamond(char charc)
        {
            List<String> topLayer = CreateTopLayer(charc);
            List<String> bottomLayer = topLayer.ToList();
            bottomLayer.Reverse();
            bottomLayer.RemoveAt(0);
            topLayer = topLayer.Concat(bottomLayer).ToList();

            return topLayer;
        }

        private static List<String> CreateTopLayer(char charac)
        {
            List<String> topLayer;
            char[] az = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();
            var charIndex = Array.IndexOf(az, Char.ToLower(charac));
            topLayer = new List<string>();
            if (charIndex == 0)
            {
                topLayer.Add("A");
                return topLayer;
            }
            else
            {
                int padAdjust = 1;
                int spacer = 2;
                for (int i = 0; i <= charIndex; i++)
                {
                    string row = "";
                    if (i == 0)
                    {
                        row = row.PadLeft(charIndex) + Char.ToUpper(az[i]) + row.PadRight(charIndex);
                        topLayer.Add(row);
                    }
                    else
                    {
                        row = row.PadLeft(charIndex - padAdjust) + Char.ToUpper(az[i]) + row.PadRight((spacer * i) - 1) + Char.ToUpper(az[i]) + row.PadRight(charIndex - padAdjust);
                        padAdjust++;
                        topLayer.Add(row);
                    }
                }
            }
            return topLayer;
        }
    }
}