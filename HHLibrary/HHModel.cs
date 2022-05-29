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
    public struct Vacancy
    {
        public string id { get; private set; }
        public string name { get; private set; }
        public string salary_from { get; private set; }
        public string salary_to { get; private set; }
        public string salary_currency { get; private set; }
        public string employer_name { get; private set; }
        public string address { get; private set; }
        public string info { get; private set; }

        public Vacancy(dynamic obj)
        {
            this.id = obj.id;
            this.name = obj.name;
            if (obj.salary != null)
            {
                this.salary_from = (obj.salary.from == null) ? " " : obj.salary.from;
                this.salary_to = (obj.salary.to == null) ? " " : obj.salary.to;
                this.salary_currency = (obj.salary.currency == null) ? " " : obj.salary.currency;
            }
            else
            {
                this.salary_from = "-";
                this.salary_to = "-";
                this.salary_currency = "-";
            }

            this.employer_name = obj.employer.name;
            if (obj.address != null)
            {
                this.address = obj.address.city + " " + obj.address.street + " " + obj.address.building;
            }
            else
            {
                this.address = "-";
            }
            if (obj.description != null)
            {
                this.info = obj.description;
            }
            else
            {
                this.info = "-";
            }
        }
    }

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

        public List<Vacancy> JsonParseStringItems(string json)
        {
            List<Vacancy> vacancies = new List<Vacancy>();

            dynamic obj = JObject.Parse(json);

            foreach (dynamic item in obj.items)
            {
                vacancies.Add(new Vacancy(item));
            }

            return vacancies;
        }
    }
}
