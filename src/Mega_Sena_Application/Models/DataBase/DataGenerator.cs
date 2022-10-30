using Mega_sena_front.Controller;
using Mega_sena_front.Models;
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
                    if (n < 10) resultStr = resultStr + '0' + n;
                    else resultStr = resultStr + n;
                }

                megaSenas[i] = new MegaSena
                {
                    Id = size - i,
                    Prize = rnd.Next(50000000, 250000000),
                    StartTime = new DateTime(year, month, 1),
                    EndTime = new DateTime(year, month, lastDay),
                    Status = (month == currentMonth && year == currentYear) ? "Aberta" : "Encerrada",
                    Result = (month == currentMonth && year == currentYear) ? null : resultStr
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

        public static LotoFacil[] LotoFacils(int size)
        {
            LotoFacil[] lotoFacils = new LotoFacil[size];
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

                int[] result = Feature.GenerateSequence("Lotofacil", 15);

                string resultStr = "";

                foreach (int n in result)
                {
                    if (n < 10) resultStr = resultStr + '0' + n;
                    else resultStr = resultStr + n;
                }

                lotoFacils[i] = new LotoFacil
                {
                    Id = size - i,
                    Prize = rnd.Next(50000000, 250000000),
                    StartTime = new DateTime(year, month, 1),
                    EndTime = new DateTime(year, month, lastDay),
                    Status = (month == currentMonth && year == currentYear) ? "Aberta" : "Encerrada",
                    Result = (month == currentMonth && year == currentYear) ? null : resultStr
            };

                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }

            }
            return lotoFacils;
        }

        public static DuplaSena[] DuplaSenas(int size)
        {
            DuplaSena[] duplas = new DuplaSena[size];
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

                int[] result1 = Feature.GenerateSequence("DuplaSena");
                int[] result2 = Feature.GenerateSequence("DuplaSena");

                string resultStr = "";

                foreach (int n in result1)
                {
                    if (n < 10) resultStr = resultStr + '0' + n;
                    else resultStr = resultStr + n;
                }

                foreach (int n in result2)
                {
                    if (n < 10) resultStr = resultStr + '0' + n;
                    else resultStr = resultStr + n;
                }

                duplas[i] = new DuplaSena
                {
                    Id = size - i,
                    Prize = rnd.Next(50000000, 250000000),
                    StartTime = new DateTime(year, month, 1),
                    EndTime = new DateTime(year, month, lastDay),
                    Status = (month == currentMonth && year == currentYear) ? "Aberta" : "Encerrada",
                    Result = (month == currentMonth && year == currentYear) ? null : resultStr
            };

                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }

            }
            return duplas;
        }

        public static Quina[] Quinas(int size)
        {
            Quina[] quinas = new Quina[size];
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

                int[] result = Feature.GenerateSequence("Quina");

                string resultStr = "";

                foreach (int n in result)
                {
                    if (n < 10) resultStr = resultStr + '0' + n;
                    else resultStr = resultStr + n;
                }

                quinas[i] = new Quina
                {
                    Id = size - i,
                    Prize = rnd.Next(50000000, 250000000),
                    StartTime = new DateTime(year, month, 1),
                    EndTime = new DateTime(year, month, lastDay),
                    Status = (month == currentMonth && year == currentYear) ? "Aberta" : "Encerrada",
                    Result = (month == currentMonth && year == currentYear) ? null : resultStr
        };

                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }

            }
            return quinas;
        }

        public static Lotomania[] Lotomanias(int size)
        {
            Lotomania[] lotomanias = new Lotomania[size];
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

                int[] result = Feature.GenerateSequence("Lotomania", 20);

                string resultStr = "";

                foreach (int n in result)
                {
                    if (n < 10) resultStr = resultStr + '0' + n;
                    else resultStr = resultStr + n;
                }

                lotomanias[i] = new Lotomania
                {
                    Id = size - i,
                    Prize = rnd.Next(50000000, 250000000),
                    StartTime = new DateTime(year, month, 1),
                    EndTime = new DateTime(year, month, lastDay),
                    Status = (month == currentMonth && year == currentYear) ? "Aberta" : "Encerrada",
                    Result = (month == currentMonth && year == currentYear) ? null : resultStr
        };

                month--;
                if (month == 0)
                {
                    month = 12;
                    year--;
                }

            }
            return lotomanias;
        }

    }
}
