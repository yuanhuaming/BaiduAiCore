using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Baidu.Aip.Demo
{
    public class NlpDemo
    {
        private readonly Nlp.Nlp nlp = null;

        public NlpDemo(string apiKey, string secretKey)
        {
            nlp = new Nlp.Nlp(apiKey, secretKey);
        }

        public void Lexer()
        {

            var result = nlp.Lexer("今天天气不错");
            Console.Write(result);
        }

        public void WordSeg()
        {

            var result = nlp.WordSeg("今天天气不错");
            Console.Write(result);
        }


        public void WordPos()
        {

            var result = nlp.WordPos("今天天气不错");
            Console.Write(result);
        }

        public void WordEmbedding()
        {
            // 词相似度
            var result = nlp.WordEmbeddingSimilarity("北京", "上海");
            Console.Write(result);
            // 词向量
            result = nlp.WordEmbeddingVector("北京");
            Console.Write(result);
        }

        public void Dnnlm()
        {

            var result = nlp.DNN_LM_Cn("今天天气不错");
            Console.Write(result);
        }

        public void SimNet()
        {

            var result = nlp.Simnet("你好百度", "你好世界");
            Console.Write(result);
        }

        public void CommentTag()
        {

            var result = nlp.CommentTag("个人觉得这车不错，外观漂亮年轻，动力和操控性都不错", 10);
            Console.Write(result);
        }

        public void SentimentClassify()
        {

            var result = nlp.SentimentClassify("个人觉得这车不错，外观漂亮年轻，动力和操控性都不错");
            Console.Write(result);
        }

        public void DepParser()
        {

            var options = new Dictionary<string, object>
            {
                {"mode", 1}
            };
            var result = nlp.DepParser("今天天气不错", options);
            Console.Write(result);
        }
    }
}