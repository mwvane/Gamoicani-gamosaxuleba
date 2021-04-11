using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace გამოიცანი_გამოსახულება
{
    public static class Search
    {
        public static List<string> Result(int length,string contains)
        {
            List<string> l = new List<string>();
            Dictionary<string, string> d = new Dictionary<string, string>();
            string temp = "";
            string tempContains = contains;
            foreach(KeyValuePair<string,string> kvp in Base._dictionary)
            {
                int counter = 0;
                if(kvp.Value.Length == length)
                {
                    if(kvp.Value == "დურბინტი")
                    {
                        MessageBox.Show("");
                    }
                    for (int i = 0; i < length; i++)
                    {
                        if (contains.Contains(kvp.Value[i]))
                        {
                            counter++;
                            for (int j = 0,count = 0; j < contains.Length; j++)
                            {
                                if(contains[j] == kvp.Value[i] && count == 0)
                                {
                                    count++;
                                    continue;
                                }
                                else
                                {
                                    temp += contains[j];
                                }
                                
                            }
                            contains = temp;
                            temp = "";
                        }
                    }

                    contains = tempContains;
                    if (counter == length)
                    {
                        l.Add(kvp.Key);
                        counter = 0;
                    }
                }
            }
            return l;
        }
    }
}
