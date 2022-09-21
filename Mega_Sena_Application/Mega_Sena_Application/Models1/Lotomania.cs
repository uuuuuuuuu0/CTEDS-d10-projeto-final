using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena_Application.Models
{
    internal class Lotomania : Lottery_Game 
    {
        public Lotomania(int Number, string Name, DateTime Initial_Date, DateTime Last_Date, int[] Result, string[] Winners, int n_Winners)
        {
            this.Type = "Lotomania";
            
            this.Number = Number;
            this.Name = Name;
            this.Initial_Date = Initial_Date;
            this.Last_Date = Last_Date;
            this.Result = Result;
            this.Winners = Winners;
        }
    }
}
