using System;
using System.Linq;

namespace MinimalReproducibleExample
{
    internal static class Program
    {
        internal static void Main()
        {
            //setup your connection
            var connStr = @"Persist Security Info = False;Trusted_Connection=True;database=mrp;server=.";
            //create DB manually CREATE.sql

            try
            {
                using (var db = FooContext.CreateContext(connStr))
                {
                    var bar = db.Bars.FirstOrDefault();
                    Console.WriteLine(bar?.BarUniqueId.BarId);
                    Console.WriteLine("OK, no errors");
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }
    }
}
