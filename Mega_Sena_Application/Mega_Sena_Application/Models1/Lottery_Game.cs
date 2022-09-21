using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Sena_Application.Models
{
    internal abstract class Lottery_Game
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
}
