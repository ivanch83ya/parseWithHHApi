using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HHLibrary
{
    public class HHModel
    {
        /// <summary>
        /// Получение ответа на Get запрос
        /// </summary>
        /// <param name="request">URL запроса</param>
        /// <returns></returns>
        public string RequestGet(string request)
        {
            string tmp = "";
            try
            {
                WebClient client = new WebClient();
                client.Headers.Add("user-agent", "Chrome");
                Stream stream = client.OpenRead(request);

                StreamReader sr = new StreamReader(stream);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    tmp += line;
                }
                stream.Close();
            }
            catch (Exception e)
            {
                tmp = e.Message;
            }
            return tmp;
        }

        public string JsonParseString(string json)
        {
            string tmp = "";
            dynamic obj = JObject.Parse(json);
            tmp += obj.name + "\r\n";
            tmp += " Зарплата с " + obj.salary.from + " до " + obj.salary.to + " " + obj.salary.currency + "\r\n";
            //tmp = ("{0} \nЗарплата с {1} до {2} {3}", obj.name, obj.salary.from, obj.salary.to, obj.salary.currence);



            return tmp;
        }
    }
}
