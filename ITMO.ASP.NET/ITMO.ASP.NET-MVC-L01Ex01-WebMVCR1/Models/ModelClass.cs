using System;

namespace ITMO.ASP.NET_MVC_L01Ex01_WebMVCR1.Models
{
    public class ModelClass
    { 
        public static string ModelHello()
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";
            return Greeting;
        } 
    }
}
