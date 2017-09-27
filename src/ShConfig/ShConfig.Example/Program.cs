using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShConfig.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "file.sh";
            var dic = new Dictionary<string,string> {
                ["name"]="Bob",
                ["email"]="bob@example.com",
                ["phone"]="+123456789",
                ["country"]="Earth"
            };

            Sh.Write(file, dic);

            var data = Sh.Read("file.sh");
            var email = data["email"];
        }
    }
}
