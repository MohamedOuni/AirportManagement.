using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.UI.Console
{
    internal class chapitre3
    {
        public static void ouni1()
        {
            using(var context = new Context())
            {
                context.Planes.AddRange (InMemorySource.Boeing1, InMemorySource.Boeing2, InMemorySource.Airbus);
                context.Flights.AddRange(InMemorySource.Flights);
                context.Staffs.AddRange(InMemorySource.Staffs);
                context.Travellers.AddRange(InMemorySource.Travellers);

                context.SaveChanges();
            }
        }
        public static void ouni2()
        {
            using (var context = new Context())
            {
                context.Tickets.ToList().ShowList("=== Tickets list ===", System.Console.WriteLine);
            }
        }
    }
}
