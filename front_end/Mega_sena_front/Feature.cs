using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_sena_front
{
    internal class Feature
    {
        public static int[] GenerateSequence(string Type, int n)
        {
            int Size;
            int Max;
            int Min;

            switch (Type)
            {
                case "Mega-Sena":
                    Size = 6;
                    Max = 60;
                    Min = 1;
                    break;

                case "Dupla-Sena":
                    Size = 12;
                    Max = 60;
                    Min = 1;
                    break;

                case "Lotofácil":
                    Size = n; //n from 15 to 18 
                    Max = 25;
                    Min = 1;
                    break;

                case "Lotomania":
                    Size = 50;
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
            return Sequence;
        }

        public static int[] GenerateSequence(string Type)
        {
            int Size;
            int Max;
            int Min;

            switch (Type)
            {
                case "Mega-Sena":
                    Size = 6;
                    Max = 60;
                    Min = 1;
                    break;

                case "Dupla-Sena":
                    Size = 12;
                    Max = 60;
                    Min = 1;
                    break;

                case "Lotofácil":
                    throw new ArgumentException();

                case "Lotomania":
                    Size = 50;
                    Max = 99;
                    Min = 0;
                    break;

                case "Quina":
                    throw new ArgumentException();

                default:
                    throw new ArgumentException();
            }

            int[] Sequence = new int[Size];

            Random r = new Random();

            for (int i = 0; i < Size; i++)
            {
                Sequence[i] = r.Next(Min, Max);
            }

            return Sequence;
        }

        int[] ConvertSequence (string result)
        {
            int[] sequence = new int[(result.Length)/2];
            for (int i = 0; i < result.Length/2; i++)
            {
                sequence[i] = 10 * (result[2*i] - 48);
                sequence[i] += result[2 * i + 1] - 48;
            }
            return sequence;
        }
    }
}
