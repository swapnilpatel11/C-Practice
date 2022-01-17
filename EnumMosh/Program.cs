using System;

namespace EnumMosh
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            // we can get value of shiping method
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //we can get shipping method name from value as well
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());
            
            //parse string to get value 
            var methodName = "Express";
           var shippingMethod =  (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);


        }
    }
}
