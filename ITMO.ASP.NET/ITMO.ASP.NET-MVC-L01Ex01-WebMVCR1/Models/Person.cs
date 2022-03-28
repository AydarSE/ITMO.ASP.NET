namespace ITMO.ASP.NET_MVC_L01Ex01_WebMVCR1.Models
{
    public class Person
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public override string ToString() => FirstName + " " + LastName;
        
    }
}
