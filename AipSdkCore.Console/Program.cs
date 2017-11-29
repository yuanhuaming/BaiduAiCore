using Baidu.Aip.Demo;
using System;

namespace AipSdkCore
{
    class Program
    {
        static void Main(string[] args)
        {
            ImageClassifyDemo demo1 = new ImageClassifyDemo("REC6IUxVrHm8EzXr47UWHM3W", "pAxR02BK2h0GLyb06OpQcLChOELFoT2b");
            //demo1.CarDetectDemo(@"C:\Users\yuanhuaming\Desktop\2017111316340934918938_5707273_16.jpg");
            demo1.DishDetectDemo(@"C:\Users\yuanhuaming\Desktop\timg.jpg");


            Console.ReadKey();
        }
    }
}
