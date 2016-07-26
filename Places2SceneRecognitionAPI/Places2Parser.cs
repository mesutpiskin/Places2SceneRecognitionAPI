using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;

namespace Places2SceneRecognitionAPI
{
   public class Places2Parser
    {
        private WebClient webClient;
        private string webData;
        private string imageUrl;
       
        public Places2Parser()
        {
            //todu init.
           
        }
        /// <summary>
        /// Connect places2 server and get tag on image
        /// </summary>
        /// <param name="imageUrl">http image uri</param>
        /// <returns>image tag and match rate 
        /// <seealso cref="WebResult"/>
        /// </returns>
        public List<WebResult> ParseData(string imageUrl)
        {
            List<WebResult> webResults;
            this.imageUrl = imageUrl;
            //todo upload to server
            webClient = new WebClient();
            string[] webDataArray=null;
            try
            {
                byte[] raw = webClient.DownloadData(string.Format("http://places2.csail.mit.edu/cgi-bin/image.py?url={0}",imageUrl));
                webData = System.Text.Encoding.UTF8.GetString(raw);
                webDataArray = webData.Split(',');

            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }
            WebResult webResult;
            webResults = new List<WebResult>();
            foreach (string result in webDataArray)
            {
                string[] categorieParser = result.Split(':');
                try
                {
                    decimal ratio = Decimal.Parse(categorieParser[1].Replace(" ", string.Empty), CultureInfo.InvariantCulture);
                    webResult = new WebResult();
                    if (ratio!=0)
                    {
                        webResult.Tag = categorieParser[0].Replace("\"",string.Empty);
                        webResult.Ratio = ratio;
                        webResults.Add(webResult);
                    }               
                }
                catch
                {  }
             
            }
         
            return webResults;

        }

    }
}
