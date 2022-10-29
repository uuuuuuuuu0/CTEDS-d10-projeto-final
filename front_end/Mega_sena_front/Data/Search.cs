using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mega_sena_front.Data
{
    public class Search
    {
        private Context context;

        public Search(Context context)
        {
            this.context = context;
        }

        public List<MegaSena> MegaSenas(string str)
        { 
            bool numeric = true;
            int n = 0;
            List<MegaSena> list = new List<MegaSena>();
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
                foreach (MegaSena l in context.megaSenas)
                {
                    if (l.Id == n) list.Add(l);
                }

                foreach (MegaSena l in context.megaSenas)
                {
                    if ((int)l.Prize == n)
                    {
                        list.Add(l);
                    }
                }
            }
            else if (str.ToLower() == "aberta")
            {
                foreach(MegaSena l in context.megaSenas)
                {
                    if(l.Status == "Aberta") list.Add(l);
                }
            }
            else if (str.ToLower() == "encerrada")
            {
                foreach(MegaSena l in context.megaSenas)
                {
                    if (l.Status == "Encerrada") list.Add(l);
                }
            }
            else
            {
                try
                {
                    DateTime date = DateTime.Parse(str);
                    foreach (MegaSena l in context.megaSenas)
                    {
                        if (date.Month == l.StartTime.Month && date.Year == l.StartTime.Year)
                        {
                            list.Add(l);
                        }
                    }
                }
                catch(Exception e)
                {
                    string sequence = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
                    numeric = true;
                    foreach (char c in sequence)
                    {
                        if (c > '9' || c < '0') numeric = false;
                    }
                    if (numeric)
                    {
                        foreach (MegaSena l in context.megaSenas)
                        {
                            if (l.Result == sequence) list.Add(l);
                        }
                    }
                }
            }

            return list;   
        }

        public List<DuplaSena> DuplaSenas(string str)
        {
            bool numeric = true;
            int n = 0;
            List<DuplaSena> list = new List<DuplaSena>();
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
                foreach (DuplaSena l in context.duplaSenas)
                {
                    if (l.Id == n) list.Add(l);
                }

                foreach (DuplaSena l in context.duplaSenas)
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
                    foreach (DuplaSena l in context.duplaSenas)
                    {
                        if (l.Status == "Aberta") list.Add(l);
                    }
                }
                else if (str.ToLower() == "encerrada")
                {
                    foreach (DuplaSena l in context.duplaSenas)
                    {
                        if (l.Status == "Encerrada") list.Add(l);
                    }
                }
                else
                {
                    try
                    {
                        DateTime date = DateTime.Parse(str);
                        foreach (DuplaSena l in context.duplaSenas)
                        {
                            if (date.Month == l.StartTime.Month && date.Year == l.StartTime.Year)
                            {
                                list.Add(l);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        string sequence = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
                        
                        numeric = true;
                        foreach (char c in sequence)
                        {
                            if (c > '9' || c < '0') numeric = false;
                        }
                        if (numeric)
                        {
                            if (sequence.Length == 24)
                            {
                                string sequence1 = sequence.Substring(0, 12);
                                string sequence2 = sequence.Substring(12, 24);
                                
                                foreach (DuplaSena l in context.duplaSenas)
                                {
                                    if (l.Result.Substring(0, 12) == sequence1 || l.Result.Substring(12, 24) == sequence2) list.Add(l);
                                }
                            }
                            else if (sequence.Length == 12)
                            {
                                foreach (DuplaSena l in context.duplaSenas)
                                {
                                    if (l.Result.Substring(0, 12) == sequence || l.Result.Substring(12, 24) == sequence) list.Add(l);
                                }
                            }
                            
                        }
                    }
                }
            }

            return list;

        }

        public List<LotoFacil> LotoFaceis(string str)
        {
            bool numeric = true;
            int n = 0;
            List<LotoFacil> list = new List<LotoFacil>();
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
                foreach (LotoFacil l in context.lotoFacils)
                {
                    if (l.Id == n) list.Add(l);
                }

                foreach (LotoFacil l in context.lotoFacils)
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
                    foreach (LotoFacil l in context.lotoFacils)
                    {
                        if (l.Status == "Aberta") list.Add(l);
                    }
                }
                else if (str.ToLower() == "encerrada")
                {
                    foreach (LotoFacil l in context.lotoFacils)
                    {
                        if (l.Status == "Encerrada") list.Add(l);
                    }
                }
                else
                {
                    try
                    {
                        DateTime date = DateTime.Parse(str);
                        foreach (LotoFacil l in context.lotoFacils)
                        {
                            if (date.Month == l.StartTime.Month && date.Year == l.StartTime.Year)
                            {
                                list.Add(l);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        string sequence = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
                        numeric = true;
                        foreach (char c in sequence)
                        {
                            if (c > '9' || c < '0') numeric = false;
                        }
                        if (numeric)
                        {
                            foreach (LotoFacil l in context.lotoFacils)
                            {
                                if (l.Result == sequence) list.Add(l);
                            }
                        }
                    }
                }
            }

            return list;

        }

        public List<Lotomania> Lotomanias(string str)
        {
            bool numeric = true;
            int n = 0;
            List<Lotomania> list = new List<Lotomania>();
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
                foreach (Lotomania l in context.lotomanias)
                {
                    if (l.Id == n) list.Add(l);
                }

                foreach (Lotomania l in context.lotomanias)
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
                    foreach (Lotomania l in context.lotomanias)
                    {
                        if (l.Status == "Aberta") list.Add(l);
                    }
                }
                else if (str.ToLower() == "encerrada")
                {
                    foreach (Lotomania l in context.lotomanias)
                    {
                        if (l.Status == "Encerrada") list.Add(l);
                    }
                }
                else
                {
                    try
                    {
                        DateTime date = DateTime.Parse(str);
                        foreach (Lotomania l in context.lotomanias)
                        {
                            if (date.Month == l.StartTime.Month && date.Year == l.StartTime.Year)
                            {
                                list.Add(l);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        string sequence = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
                        numeric = true;
                        foreach (char c in sequence)
                        {
                            if (c > '9' || c < '0') numeric = false;
                        }
                        if (numeric)
                        {
                            foreach (Lotomania l in context.lotomanias)
                            {
                                if (l.Result == sequence) list.Add(l);
                            }
                        }
                    }
                }
            }

            return list;

        }

        public List<Quina> Quinas(string str)
        {
            bool numeric = true;
            int n = 0;
            List<Quina> list = new List<Quina>();
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
                foreach (Quina l in context.quinas)
                {
                    if (l.Id == n) list.Add(l);
                }

                foreach (Quina l in context.quinas)
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
                    foreach (Quina l in context.quinas)
                    {
                        if (l.Status == "Aberta") list.Add(l);
                    }
                }
                else if (str.ToLower() == "encerrada")
                {
                    foreach (Quina l in context.quinas)
                    {
                        if (l.Status == "Encerrada") list.Add(l);
                    }
                }
                else
                {
                    try
                    {
                        DateTime date = DateTime.Parse(str);
                        foreach (Quina l in context.quinas)
                        {
                            if (date.Month == l.StartTime.Month && date.Year == l.StartTime.Year)
                            {
                                list.Add(l);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        string sequence = String.Concat(str.Where(c => !Char.IsWhiteSpace(c)));
                        numeric = true;
                        foreach (char c in sequence)
                        {
                            if (c > '9' || c < '0') numeric = false;
                        }
                        if (numeric)
                        {
                            foreach (Quina l in context.quinas)
                            {
                                if (l.Result == sequence) list.Add(l);
                            }
                        }
                    }
                }
            }

            return list;

        }

        public int[,] MostSortedNumbers(string? lotteryStr)
        {
            int[,] mostSorted = new int[2,3];
            if (lotteryStr == "MegaSena")
            {
                var lotteries = context.megaSenas;
                int[] quantities = new int[60];
                foreach (var lottery in lotteries)
                {
                    int[] result = Feature.ConvertSequence(lottery.Result);
                    if (result == null) continue;
                    foreach (int n in result)
                    {
                        quantities[n - 1]++;
                    }
                }

                int biggestQuant = 0;
                int biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 0] = biggestPos + 1;
                mostSorted[1, 0] = biggestQuant;
                quantities[biggestPos] = -1;


                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }
                mostSorted[0, 1] = biggestPos + 1;
                mostSorted[1, 1] = biggestQuant;
                quantities[biggestPos] = -1;

                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 2] = biggestPos + 1;
                mostSorted[1, 2] = biggestQuant;
            }

            else if (lotteryStr == "DuplaSena")
            {
                var lotteries = context.duplaSenas;
                int[] quantities = new int[50];
                foreach (var lottery in lotteries)
                {
                    int[] result = Feature.ConvertSequence(lottery.Result);
                    if (result == null) continue;
                    foreach (int n in result)
                    {
                        quantities[n - 1]++;
                    }
                }

                int biggestQuant = 0;
                int biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 0] = biggestPos + 1;
                mostSorted[1, 0] = biggestQuant;
                quantities[biggestPos] = -1;


                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }
                mostSorted[0, 1] = biggestPos + 1;
                mostSorted[1, 1] = biggestQuant;
                quantities[biggestPos] = -1;

                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 2] = biggestPos + 1;
                mostSorted[1, 2] = biggestQuant;
            }

            else if (lotteryStr == "Lotomania")
            {
                var lotteries = context.megaSenas;
                int[] quantities = new int[100];
                foreach (var lottery in lotteries)
                {
                    int[] result = Feature.ConvertSequence(lottery.Result);
                    if (result == null) continue;
                    foreach (int n in result)
                    {
                        quantities[n - 1]++;
                    }
                }

                int biggestQuant = 0;
                int biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 0] = biggestPos;
                mostSorted[1, 0] = biggestQuant;
                quantities[biggestPos] = -1;


                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }
                mostSorted[0, 1] = biggestPos;
                mostSorted[1, 1] = biggestQuant;
                quantities[biggestPos] = -1;

                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 2] = biggestPos;
                mostSorted[1, 2] = biggestQuant;
            }

            else if (lotteryStr == "Quina")
            {
                var lotteries = context.quinas;
                int[] quantities = new int[80];
                foreach (var lottery in lotteries)
                {
                    int[] result = Feature.ConvertSequence(lottery.Result);
                    if (result == null) continue;
                    foreach (int n in result)
                    {
                        quantities[n - 1]++;
                    }
                }

                int biggestQuant = 0;
                int biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 0] = biggestPos + 1;
                mostSorted[1, 0] = biggestQuant;
                quantities[biggestPos] = -1;


                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }
                mostSorted[0, 1] = biggestPos + 1;
                mostSorted[1, 1] = biggestQuant;
                quantities[biggestPos] = -1;

                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 2] = biggestPos + 1;
                mostSorted[1, 2] = biggestQuant;
            }

            else if (lotteryStr == "LotoFacil")
            {
                var lotteries = context.lotoFacils;
                int[] quantities = new int[25];
                foreach (var lottery in lotteries)
                {
                    int[] result = Feature.ConvertSequence(lottery.Result);
                    if (result == null) continue;
                    foreach (int n in result)
                    {
                        quantities[n - 1]++;
                    }
                }

                int biggestQuant = 0;
                int biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 0] = biggestPos + 1;
                mostSorted[1, 0] = biggestQuant;
                quantities[biggestPos] = -1;


                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }
                mostSorted[0, 1] = biggestPos + 1;
                mostSorted[1, 1] = biggestQuant;
                quantities[biggestPos] = -1;

                biggestQuant = 0;
                biggestPos = 0;

                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] > biggestQuant)
                    {
                        biggestQuant = quantities[i];
                        biggestPos = i;
                    }
                }

                mostSorted[0, 2] = biggestPos + 1;
                mostSorted[1, 2] = biggestQuant;
            }

            else throw new ArgumentException("Wrong lotteryStr");



            return mostSorted;
        }
    }
}
