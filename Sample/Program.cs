using System;
using Places2SceneRecognitionAPI;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Places2Parser parser = new Places2Parser();
            List<WebResult> list = parser.ParseData(@"http://places2.csail.mit.edu/imgs/10.jpg");
            foreach (WebResult item in list)
            {
                Console.WriteLine("TAG:" + item.Tag + "\nRATIO:" + string.Format("{0:0.0000}\n", item.Ratio));
            }
            Console.ReadKey();
        }
    }
}
