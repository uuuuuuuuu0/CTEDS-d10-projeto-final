using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_sena_front.Data
{
    public class DataGenerator
    {
        public static MegaSena[] MegaSenas(int size)
        {
            MegaSena[] megaSenas = new MegaSena[size];
            int currentMonth = DateTime.Now.Month;
            int currentYear = DateTime.Now.Year;

            int month = currentMonth;
            int year = currentYear;

            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                int lastDay;
                if ((month % 2 == 1 && month <= 7) || (month % 2 == 0 && month > 7))
                {
                    lastDay = 31;
                }
                else if (month != 2)
                {
                    lastDay = 30;
                }
                else if (year % 4 == 0)
                {
                    lastDay = 29;
                }
                else lastDay = 28;

                int[] result = Feature.GenerateSequence("MegaSena");

                string resultStr = "";

                foreach (int n in result)
                {
                    resultStr = resultStr + n;
                }

                megaSenas[i] = new MegaSena
                {
                    Id = size - i,
                    Prize = rnd.Next(50000000, 250000000),
                    StartTime = new DateTime(year, month, 1),
                    EndTime = new DateTime(year, month, lastDay),
                    Status = (month == currentMonth && year == currentYear) ? "Aberta" : "Encerrada",
                    Result = resultStr
                };
                
                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }
                
            }
            return megaSenas;
        }
        
    }
}
