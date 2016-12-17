using System;
using System.Globalization;
using System.Threading;
using System.Web;
using System.Xml.Linq;

namespace _03_GoogleAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string address = "г. Киев, ул. Жилянская, 128/28";
            string url = String.Format("http://maps.google.com/maps/api/geocode/xml?address={0}&sensor=false", HttpUtility.UrlEncode(address));

            CultureInfo culture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");

            XDocument xdoc = XDocument.Load(url);
            Console.WriteLine(xdoc.ToString());
        }
    }
}
