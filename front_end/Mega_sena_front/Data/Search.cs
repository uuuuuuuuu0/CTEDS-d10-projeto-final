using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_sena_front.Data
{
    public class Search
    {
        public List<Lottery> Seek<Lottery>(Lottery[] lotteries, string str) where Lottery : LotteryGame 
        { 
            bool numeric = true;
            int n = 0;
            List<Lottery> list = new List<Lottery>();
            try
            {
                n = int.Parse(str);
            }
            catch (Exception ex)
            {
                numeric = false;
            }

            if (numeric)
            {
                foreach (Lottery l in lotteries)
                {
                    if (l.Id == n) list.Add(l);
                }

                foreach (Lottery l in lotteries)
                {
                    if ((int)l.Prize == n)
                    {
                        list.Add(l);
                    }
                }
            }
            else
            {
                if (str.ToLower() == "aberta")
                {
                    foreach(Lottery l in lotteries)
                    {
                        if(l.Status == "Aberta") list.Add(l);
                    }
                }
                else if (str.ToLower() == "encerrada")
                {
                    foreach(Lottery l in lotteries)
                    {
                        if (l.Status == "Encerrada") list.Add(l);
                    }
                }
                else
                {
                    try
                    {
                        DateTime date = DateTime.Parse(str);
                        foreach (Lottery l in lotteries)
                        {
                            if (date.Month == l.StartTime.Month && date.Year == l.StartTime.Year)
                            {
                                list.Add(l);
                            }
                        }
                    }
                    catch(Exception e)
                    {
                        return null;
                    }
                }
            }

            return list;
            
        }
    }
}
