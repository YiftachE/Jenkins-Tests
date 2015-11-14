using GetMeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpData dataGetter = new HttpData();
            Console.WriteLine(dataGetter.GetStringJsonData());
        }
    }
}
