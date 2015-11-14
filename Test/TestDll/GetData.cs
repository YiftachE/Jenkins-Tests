using GetMeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDll
{
    public class GetData
    {
        public void ExecuteDataGetter()
        {
            HttpData data = new HttpData();
            data.GetStringJsonData();
        }
    }
}
