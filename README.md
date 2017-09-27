# ShConfig
Read sh config from C#

## Examples
### Write data
```csharp
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
        }
    }
```
Output `file.sh`:
```sh
name=Bob
email=bob@example.com
phone=+123456789
country=Earth
```
### Read data
```csharp
class Program
    {
        static void Main(string[] args)
        {
            var file = "file.sh";

            var data = Sh.Read("file.sh");
            var email = data["email"];
        }
    }
```
