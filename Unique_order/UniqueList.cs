using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Unique_order
{
    public class UniqueList
    {
        public void UniqueInOrder(string text)
        {
            List<char> list = new List<char>();
            for(int i = 0; i < text.Length; i++)
            {
                                                
                int a = i + 1;
                if (a == text.Length)
                {
                    a = text.Length - 1;
                }
                if ( text[i] != text[a])
                {
                    list.Add(text[i]);
                }
            }
            list.Add(text[text.Length-1]);
            foreach(char c in list)
            {
                Console.WriteLine(c);
            }
        }
        public void UniqueInOrder(int[] ints)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < ints.Length; i++)
            {
                int a = 0;
                a = i + 1;
                if (a == ints.Length)
                {
                    a = ints.Length - 1;
                }
                if (ints[i] != ints[a])
                {
                    list.Add(ints[i]);
                }
            }
            list.Add(ints[ints.Length - 1]);
            foreach (int c in list)
            {
                Console.Write(c);
            }
        }
    }
}
