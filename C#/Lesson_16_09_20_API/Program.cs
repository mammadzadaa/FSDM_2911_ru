using System;
using System.IO;
using System.Net;
using System.Text.Json;
//using Newtonsoft.Json;

namespace Lesson_16_09_20_API
{

    public class BakuBus
    {
        public BUS[] BUS { get; set; }
    }

    public class BUS
    {
        public Attributes @attributes { get; set; }
    }

    public class Attributes
    {
        public string BUS_ID { get; set; }
        public string PLATE { get; set; }
        public string DRIVER_NAME { get; set; }
        public string CURRENT_STOP { get; set; }
        public string PREV_STOP { get; set; }
        public string SPEED { get; set; }
        public string BUS_MODEL { get; set; }
        public string LATITUDE { get; set; }
        public string LONGITUDE { get; set; }
        public string ROUTE_NAME { get; set; }
        public object LAST_UPDATE_TIME { get; set; }
        public string DISPLAY_ROUTE_CODE { get; set; }
        public string SVCOUNT { get; set; }
    }

    public class ExchageRates
    {
        public Rates rates { get; set; }
        public string @base { get; set; }
        public string date { get; set; }
    }

    public class Rates
    {
        public decimal CAD { get; set; }
        public decimal HKD { get; set; }
        public decimal ISK { get; set; }
        public decimal PHP { get; set; }
        public decimal DKK { get; set; }
        public decimal HUF { get; set; }
        public decimal CZK { get; set; }
        public decimal GBP { get; set; }
        public decimal RON { get; set; }
        public decimal SEK { get; set; }
        public decimal IDR { get; set; }
        public decimal INR { get; set; }
        public decimal BRL { get; set; }
        public decimal RUB { get; set; }
        public decimal HRK { get; set; }
        public decimal JPY { get; set; }
        public decimal THB { get; set; }
        public decimal CHF { get; set; }
        public decimal EUR { get; set; }
        public decimal MYR { get; set; }
        public decimal BGN { get; set; }
        public decimal TRY { get; set; }
        public decimal CNY { get; set; }
        public decimal NOK { get; set; }
        public decimal NZD { get; set; }
        public decimal ZAR { get; set; }
        public decimal USD { get; set; }
        public decimal MXN { get; set; }
        public decimal SGD { get; set; }
        public decimal AUD { get; set; }
        public decimal ILS { get; set; }
        public decimal KRW { get; set; }
        public decimal PLN { get; set; }
    }

    //class ExchageRates
    //{
    //    public Rates rates { get; set; }
    //    public string @base { get; set; }
    //    public DateTime date { get; set; }

    //}

    //class Rates
    //{
    //    public decimal RUB { get; set; }
    //    public decimal TRY { get; set; }
    //    public decimal GBP { get; set; }
    //    public decimal EUR { get; set; }

    //}
    class Program
    {
        static void Main(string[] args)
        {

            //WebClient webClient = new WebClient();

            //string url = "https://bakubus.az/az/ajax/apiNew1";

            //string response = webClient.DownloadString(url);

            //var result = JsonSerializer.Deserialize<BakuBus>(response);


            //Console.WriteLine(result.BUS.Length);



            //WebClient webClient = new WebClient();

            //string url = " https://api.exchangeratesapi.io/latest?base=USD";

            //string response = webClient.DownloadString(url);

            //var result = JsonSerializer.Deserialize<ExchageRates>(response);

            //Console.WriteLine(result.@base.ToLower());
            //Console.WriteLine(result.date);

            //Console.WriteLine(result.rates.EUR);
            //Console.WriteLine(result.rates.RUB);


            //dynamic a = 12;
            //Console.WriteLine(a);
            //a = "dhsagk";
            //Console.WriteLine(a);
            //Console.WriteLine(a.ToUpper());
            //a = 123.54m;
            //Console.WriteLine(a);
            //Console.WriteLine(a.ToUpper());


            //var b = 12;
            //b = "dsadas";


            //WebClient webClient = new WebClient();

            //string url = " https://api.exchangeratesapi.io/latest?base=USD";

            //string response = webClient.DownloadString(url);

            //dynamic result = JsonConvert.DeserializeObject(response);

            //try
            //{
            //    Console.WriteLine(result.@base);
            //    Console.WriteLine(result.date);
            //    Console.WriteLine(result.rates.RUB);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



            //WebClient webClient = new WebClient();

            //var url = "https://itstep.org/";

            //string response = webClient.DownloadString(url);

            //Console.WriteLine(response);

            //File.WriteAllText("step.html",response);
        }
    }
}
