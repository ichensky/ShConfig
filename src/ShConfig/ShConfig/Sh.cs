using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShConfig
{
    public static class Sh
    {
        public static Dictionary<string, string> Read(string path)
        {
            int i;
            var s = new Dictionary<string, string>();
            var list = System.IO.File.ReadAllLines(path);
            foreach (var item in list)
            {
                var str = item.TrimStart();
                if (str.Length > 0 && str.IndexOf('#') != 0)
                {
                    for (i = 0; i < str.Length; i++)
                    {
                        if (str[i] == '=')
                        {
                            break;
                        }
                    }
                    if (i == 0)
                    {
                        throw new Exception("Not valid format of data.");
                    }
                    var key = str.Remove(i);
                    var value = str.Remove(0, i + 1);

                    if (s.ContainsKey(key))
                    {
                        s[key] = value;
                    }
                    else
                    {
                        s.Add(key, value);
                    }
                }
            }
            return s;
        }
        public static void Write(string path, Dictionary<string, string> data)
        {
            System.IO.File.WriteAllLines(path, data.Select(x => x.Key + '=' + x.Value));
        }
    }
}
