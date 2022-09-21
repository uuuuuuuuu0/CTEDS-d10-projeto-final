using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena_Application.Models
{
    internal class Federal : Lottery_Game 
    {
        public Federal(int Number, string Name, DateTime Initial_Date, DateTime Last_Date, int[] Result, string[] Winners, int n_Winners)
        {
            this.Type = "Federal";
            
            this.Number = Number;
            this.Name = Name;
            this.Initial_Date = Initial_Date;
            this.Last_Date = Last_Date;
            this.Result = Result;
            this.Winners = Winners;
        }
    }
}
