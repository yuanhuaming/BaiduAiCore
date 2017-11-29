using System;
using System.Collections.Generic;
using System.IO;

namespace Baidu.Aip.Demo
{
     public  class ImageClassifyDemo
    {
        private ImageClassify.ImageClassify client;
  
        public  ImageClassifyDemo(string apiKey, string secretKey)
        {
            client = new ImageClassify.ImageClassify(apiKey, apiKey);
        }

        /// <summary>
        /// 菜品识别
        /// </summary>
        /// <param name="filePath"></param>
        public void DishDetectDemo(string filePath)
        {
            var image = File.ReadAllBytes(filePath);
            // 调用菜品识别
            var result = client.DishDetect(image);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>
            {
                {"top_num", 3}
            };
            // 带参数调用菜品识别
            result = client.DishDetect(image, options);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 车辆识别
        /// </summary>
        /// <param name="filePath"></param>
        public void CarDetectDemo(string filePath)
        {
            var image = File.ReadAllBytes(filePath);
            // 调用车辆识别
            var result = client.CarDetect(image);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>
            {
                {"top_num", 3}
            };
            // 带参数调用车辆识别
            result = client.CarDetect(image, options);
            Console.WriteLine(result);
        }
        /// <summary>
        /// logo 商标识别-检索
        /// </summary>
        /// <param name="filePath"></param>
        public void LogoSearchDemo(string filePath)
        {
            var image = File.ReadAllBytes(filePath);
            // 调用logo商标识别
            var result = client.LogoSearch(image);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>
            {
                {"custom_lib", true}
            };
            // 带参数调用logo商标识别
            result = client.LogoSearch(image, options);
            Console.WriteLine(result);
        }

        /// <summary>
        /// logo 商标识别-入库
        /// </summary>
        /// <param name="filePath"></param>
        public void LogoAddDemo(string filePath)
        {
            var image = File.ReadAllBytes(filePath);
            var brief = "{\"name\": \"宝马\",\"code\":\"666\"}";

            // 调用logo入库
            var result = client.LogoAdd(image, brief);
            Console.WriteLine(result);
        }

        /// <summary>
        /// logo 商标识别-删除
        /// </summary>
        /// <param name="filePath"></param>
        public void LogoDeleteByImageDemo(string filePath)
        {
            var image = File.ReadAllBytes(filePath);
            // 调用删除logo，传入参数为图片
            var result = client.LogoDeleteByImage(image);
            Console.WriteLine(result);
        }

       /// <summary>
       /// 
       /// </summary>
        public void LogoDeleteBySignDemo()
        {
            var contSign = "8cnn32frvrr2cd901";

            // 调用删除logo，传入参数为图片签名
            var result = client.LogoDeleteBySign(contSign);
            Console.WriteLine(result);
        }
        /// <summary>
        /// 图像主体检测
        /// </summary>
        /// <param name="filePath"></param>
        public void ObjectDetectDemo(string filePath)
        {
            var image = File.ReadAllBytes(filePath);
            // 调用图像主体检测
            var result = client.ObjectDetect(image);
            Console.WriteLine(result);
            // 如果有可选参数
            var options = new Dictionary<string, object>
            {
                {"with_face", 0}
            };
            // 带参数调用图像主体检测
            result = client.ObjectDetect(image, options);
            Console.WriteLine(result);
        }
    }
}