using System;
using System.Collections.Generic;
using System.IO;
using Baidu.Aip.Ocr;

namespace Baidu.Aip.Demo
{
    internal class OcrDemo
    {
        private readonly Ocr.Ocr client =null;

        private readonly Form form = null;

        public OcrDemo(string apiKey, string secretKey)
        {
            client = new Ocr.Ocr(apiKey, secretKey);

            form = new Form(apiKey,secretKey);
        }

        public   void GeneralBasic(string filePath)
        {
            
            var image = File.ReadAllBytes(filePath);

            // 通用文字识别
            var result = client.GeneralBasic(image);

            // 图片url
            result = client.GeneralBasic("https://www.baidu.com/img/bd_logo1.png");
        }

        public   void GeneralEnhanced(string filePath)
        {
          
            var image = File.ReadAllBytes(filePath);

            // 带生僻字版
            var result = client.GeneralEnhanced(image);
        }

        public   void GeneralWithLocatin(string filePath)
        {
            
            var image = File.ReadAllBytes(filePath);

            // 带位置版本
            var result = client.GeneralWithLocatin(image, null);
        }

        public   void WebImage(string filePath)
        {
           
            var image = File.ReadAllBytes(filePath);

            // 网图识别
            var result = client.WebImage(image, null);
        }

        public   void Accurate(string filePath)
        {
          
            var image = File.ReadAllBytes(filePath);

            // 高精度识别
            var result = client.Accurate(image);
        }

        public   void AccurateWithLocation(string filePath)
        {
           
            var image = File.ReadAllBytes(filePath);

            // 高精度识别(带位置信息)
            var result = client.AccurateWithLocation(image);
        }


        public   void BankCard(string filePath)
        {
            
            var image = File.ReadAllBytes(filePath);

            // 银行卡识别
            var result = client.BankCard(image);
        }

        public   void Idcard(string filePath)
        {
            
            var image = File.ReadAllBytes(filePath);

            var options = new Dictionary<string, object>
            {
                {"detect_direction", "true"} // 检测方向
            };
            // 身份证正面识别
            var result = client.IdCardFront(image, options);
            // 身份证背面识别
            result = client.IdCardBack(image);
        }

        public   void DrivingLicense(string filePath)
        {
          
            var image = File.ReadAllBytes(filePath);
            var result = client.DrivingLicense(image);
        }

        public   void VehicleLicense(string filePath)
        {
            
            var image = File.ReadAllBytes(filePath);
            var result = client.VehicleLicense(image);
        }

        public   void PlateLicense(string filePath)
        {
             
            var image = File.ReadAllBytes(filePath);
            var result = client.PlateLicense(image);
        }

        public   void Receipt(string filePath)
        {
           
            var image = File.ReadAllBytes(filePath);
            var options = new Dictionary<string, object>
            {
                {"recognize_granularity", "small"} // 定位单字符位置
            };
            var result = client.Receipt(image, options);
        }


        public   void BusinessLicense(string filePath)
        {
           
            var image = File.ReadAllBytes(filePath);
            var result = client.BusinessLicense(image);
        }


        #region 表单识别



 

        public void FormBegin(string filePath)
        {
        
            var image = File.ReadAllBytes(filePath);
            form.DebugLog = false; // 是否开启调试日志

            var result = form.BeginRecognition(image);
            Console.Write(result);
        }

        public void FormGetResult()
        {
         
            var options = new Dictionary<string, object>
            {
                {"result_type", "json"} // 或者为excel
            };
            var result = form.GetRecognitionResult("123344", options);
            Console.Write(result);
        }

        public void FormToJson(string filePath)
        {
          
            var image = File.ReadAllBytes(filePath);
            form.DebugLog = false; // 是否开启调试日志

            // 识别为Json
            var result = form.RecognizeToJson(image);
            Console.Write(result);
        }

        public void FormToExcel(string filePath)
        {
            
            var image = File.ReadAllBytes(filePath);
            form.DebugLog = false; // 是否开启调试日志

            // 识别为Excel
            var result = form.RecognizeToExcel(image);
            Console.Write(result);
        }

        #endregion
    }
}