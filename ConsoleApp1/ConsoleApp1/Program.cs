using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Collections
{
    class Prog
    {
        static void Main(string[] args)
        {
            Kerosene Kerosene = new Kerosene(100, 50, "Керосин ТС-1");
            Kerosene.Dencity();
            Petrol Petrol = new Petrol(100, 75, "Автомобильный бензин АИ-95");
            Petrol.Dencity();
            DieselFluel DieselFluel = new DieselFluel(100, 85, "Дизельное топливо ДТ62");
            DieselFluel.Dencity();

                       

            List<string> products = new List<string>();
            products.Add("DieselFluel");
            products.Add("Petrol");
            products.Add("Kerosene");

            OilProducts[] oilproducts = new OilProducts[] { DieselFluel, Petrol, Kerosene };

            var sortedoil = from i in oilproducts
                         orderby i.Name
                         select i;

            
            foreach (OilProducts u in sortedoil)
                Console.WriteLine(u.Name);

            Console.Read();
            

        }


    }
        
    }

