using Baidu.Aip.Demo;
using System;
using System.Text;

namespace AipSdkCore
{
    class Program
    {
        static void Main(string[] args)
        {

#if NETSTANDARD2_0 || NETCOREAPP2_0
            //  注册了CodePages 编码则为UTF-8
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
#endif

  
            
            Console.ReadKey();
        }
    }
}
