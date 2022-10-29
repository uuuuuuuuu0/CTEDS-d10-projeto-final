using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_sena_front
{
    public class Feature
    {
        public static int[] GenerateSequence(string Type, int n)
        {
            int Size;
            int Max;
            int Min;

            switch (Type)
            {
                case "MegaSena":
                    Size = n;
                    Max = 60;
                    Min = 1;
                    break;

                case "DuplaSena":
                    Size = n;
                    Max = 50;
                    Min = 1;
                    break;

                case "Lotofacil":
                    Size = n; //n from 15 to 18 
                    Max = 25;
                    Min = 1;
                    break;

                case "Lotomania":
                    Size = n;
                    Max = 99;
                    Min = 0;
                    break;

                case "Quina":
                    Size = n; //n from 5 to 15
                    Max = 80;
                    Min = 1;
                    break;

                default:
                    throw new ArgumentException();
            }

            int[] Sequence = new int[Size];

            Random r = new Random();

            for (int i = 0; i < Size; i++)
            {
                Sequence[i] = r.Next(Min, Max);
            }

            bool done = false;

            while (!done)
            {
                done = true;
                for (int i = 0; i < Sequence.Length; i++)
                {
                    for (int j = i + 1; j < Sequence.Length; j++)
                    {
                        if (Sequence[i] == Sequence[j])
                        {
                            Sequence[j] = r.Next(Min, Max);
                            done = false;
                        }
                    }
                }
            }

            int[] SortSequence = new int[Size];
            bool[] AlreadyRead = new bool[Size];

            for (int i = 0; i < Size; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Size; i++)
            {
                int smallest = 200;
                int smallestPos = 0;
                for (int j = 0; j < Size; j++)
                {
                    if (!AlreadyRead[j] && Sequence[j] < smallest)
                    {
                        smallest = Sequence[j];
                        smallestPos = j;
                    }
                }
                AlreadyRead[smallestPos] = true;
                SortSequence[i] = smallest;
            }
            return SortSequence;
        }

        public static int[] GenerateSequence(string Type)
        {
            int Size;
            int Max;
            int Min;

            switch (Type)
            {
                case "MegaSena":
                    Size = 6;
                    Max = 60;
                    Min = 1;
                    break;

                case "DuplaSena":
                    Size = 6;
                    Max = 50;
                    Min = 1;
                    break;

                case "Lotofacil":
                    Size = 15;
                    Max = 25;
                    Min = 1;
                    break;

                case "Lotomania":
                    Size = 50;
                    Max = 99;
                    Min = 0;
                    break;

                case "Quina":
                    Size = 5;
                    Max = 80;
                    Min = 1;
                    break;

                default:
                    throw new ArgumentException();
            }

            int[] Sequence = new int[Size];

            Random r = new Random();

            for (int i = 0; i < Size; i++)
            {
                Sequence[i] = r.Next(Min, Max);
            }

            bool done = false;

            while (!done)
            {
                done = true;
                for (int i = 0; i < Sequence.Length; i++)
                {
                    for (int j = i+1; j < Sequence.Length; j++)
                    {
                        if (Sequence[i] == Sequence[j])
                        {
                            Sequence[j] = r.Next(Min, Max);
                            done = false;
                        }
                    }
                }
            }

            int[] SortSequence = new int[Size];
            bool[] AlreadyRead = new bool[Size];

            for (int i = 0; i < Size; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Size; i++)
            {
                int smallest = 200;
                int smallestPos = 0;
                for (int j = 0; j < Size; j++)
                {
                    if (!AlreadyRead[j] && Sequence[j] < smallest)
                    {
                        smallest = Sequence[j];
                        smallestPos = j;
                    }
                }
                AlreadyRead[smallestPos] = true;
                SortSequence[i] = smallest;
            }

            return SortSequence;
        }

        public static int[] ConvertSequence (string result)
        {
            if (result == null) return null;
            int[] sequence = new int[(result.Length)/2];
            for (int i = 0; i < result.Length/2; i++)
            {
                sequence[i] = 10 * (result[2*i] - 48);
                sequence[i] += result[2 * i + 1] - 48;
            }
            return sequence;
        }

        public static MegaSena[] SortByPrize(MegaSena[] games)
        {
            MegaSena[] SortGames = new MegaSena[Math.Min(games.Length, 3)];
            bool[] AlreadyRead = new bool[games.Length];

            for (int i = 0; i < games.Length; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Math.Min(games.Length, 3); i++)
            {
                double? biggest = 0;
                int biggestPos = 0;
                for (int j = 0; j < games.Length; j++)
                {
                    if (!AlreadyRead[j] && games[j].Prize > biggest)
                    {
                        biggest = games[j].Prize;
                        biggestPos = j;
                    }
                }
                AlreadyRead[biggestPos] = true;
                SortGames[i] = games[biggestPos];
            }
            return SortGames;
        }

        public static DuplaSena[] SortByPrize(DuplaSena[] games)
        {
            DuplaSena[] SortGames = new DuplaSena[Math.Min(games.Length, 3)];
            bool[] AlreadyRead = new bool[games.Length];

            for (int i = 0; i < games.Length; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Math.Min(games.Length, 3); i++)
            {
                double? biggest = 0;
                int biggestPos = 0;
                for (int j = 0; j < games.Length; j++)
                {
                    if (!AlreadyRead[j] && games[j].Prize > biggest)
                    {
                        biggest = games[j].Prize;
                        biggestPos = j;
                    }
                }
                AlreadyRead[biggestPos] = true;
                SortGames[i] = games[biggestPos];
            }
            return SortGames;
        }

        public static LotoFacil[] SortByPrize(LotoFacil[] games)
        {
            LotoFacil[] SortGames = new LotoFacil[Math.Min(games.Length, 3)];
            bool[] AlreadyRead = new bool[games.Length];

            for (int i = 0; i < games.Length; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Math.Min(games.Length, 3); i++)
            {
                double? biggest = 0;
                int biggestPos = 0;
                for (int j = 0; j < games.Length; j++)
                {
                    if (!AlreadyRead[j] && games[j].Prize > biggest)
                    {
                        biggest = games[j].Prize;
                        biggestPos = j;
                    }
                }
                AlreadyRead[biggestPos] = true;
                SortGames[i] = games[biggestPos];
            }
            return SortGames;
        }

        public static Lotomania[] SortByPrize(Lotomania[] games)
        {
            Lotomania[] SortGames = new Lotomania[Math.Min(games.Length, 3)];
            bool[] AlreadyRead = new bool[games.Length];

            for (int i = 0; i < games.Length; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Math.Min(games.Length, 3); i++)
            {
                double? biggest = 0;
                int biggestPos = 0;
                for (int j = 0; j < games.Length; j++)
                {
                    if (!AlreadyRead[j] && games[j].Prize > biggest)
                    {
                        biggest = games[j].Prize;
                        biggestPos = j;
                    }
                }
                AlreadyRead[biggestPos] = true;
                SortGames[i] = games[biggestPos];
            }
            return SortGames;
        }

        public static Quina[] SortByPrize(Quina[] games)
        {
            Quina[] SortGames = new Quina[Math.Min(games.Length, 3)];
            bool[] AlreadyRead = new bool[games.Length];

            for (int i = 0; i < games.Length; i++) AlreadyRead[i] = false;

            for (int i = 0; i < Math.Min(games.Length, 3); i++)
            {
                double? biggest = 0;
                int biggestPos = 0;
                for (int j = 0; j < games.Length; j++)
                {
                    if (!AlreadyRead[j] && games[j].Prize > biggest)
                    {
                        biggest = games[j].Prize;
                        biggestPos = j;
                    }
                }
                AlreadyRead[biggestPos] = true;
                SortGames[i] = games[biggestPos];
            }
            return SortGames;
        }
    }
}
