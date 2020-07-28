using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Group Name");

            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstaine",
                    Year = 1994
                };

                context.Groups.Add(group);
                context.SaveChanges();


                Console.WriteLine($"Id - {group.Id}, name:{group.Name}, year: {group.Year} ");
                Console.ReadLine();

            }




        }
    }
}


// Integrated Security=True; 
//<add name ="DbConnectionString" connectionString="Server=ASUS-WORK;Database=Test;User Id=test;Password=test;"/>

// try to connect DB

//  https://www.youtube.com/watch?v=3yb4idCg-Qs

// 1:27:15

