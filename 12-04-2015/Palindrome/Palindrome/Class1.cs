using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Class1
    {
        public bool Method(string str)
        {
            StringBuilder bilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLetterOrDigit(str[i]))
                {
                    bilder.Append(char.ToUpper(str[i]));
                }
            }

            str = bilder.ToString();

            Dictionary<char, int> myDictionary = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (myDictionary.ContainsKey(str[i]))
                {
                    myDictionary[str[i]]++;
                }
                else
                {
                    myDictionary.Add(str[i], 1);
                }
            }

            if (str.Length % 2 == 0)
            {
                foreach (var item in myDictionary)
                {
                    if (item.Value % 2 != 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                int some = 0;
                foreach (var item in myDictionary)
                {
                    if (item.Value % 2 != 0)
                    {
                        some++;
                    }
                    if (some > 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
