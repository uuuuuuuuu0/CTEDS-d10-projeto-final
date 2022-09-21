using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena_Application.Models
{
    internal class Lottery_Game
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime Initial_Date { get; set; }

        public DateTime Last_Date { get; set; }

        public int[] Result { get; set; }

        public string[] Winners { get; set; }

        public int n_Winners { 
            get
            {
                return this.Winners.Length;
            }
        }

        public Mega_Sena(int Number, string Name, string type, DateTime Initial_Date, DateTime Last_Date, int[] Result, string[] Winners, int n_Winners)
        {
            this.Type = Type;

            this.Number = Number;
            this.Name = Name;
            this.Initial_Date = Initial_Date;
            this.Last_Date = Last_Date;
            this.Result = Result;
            this.Winners = Winners;
        }
    }
