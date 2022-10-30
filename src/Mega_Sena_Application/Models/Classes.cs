using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_sena_front.Models
{
    public interface LotteryGame
    {
        public int Id { get; set; }
        public double? Prize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }
    }

    public class MegaSena : LotteryGame
    {
        public int Id { get; set; }
        public double? Prize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }

    }
    public class LotoFacil : LotteryGame
    {
        public int Id { get; set; }
        public double? Prize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }

    }
    public class Quina : LotteryGame
    {
        public int Id { get; set; }
        public double? Prize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }

    }
    public class Lotomania : LotteryGame
    {
        public int Id { get; set; }
        public double? Prize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }

    }
    public class DuplaSena : LotteryGame
    {
        public int Id { get; set; }
        public double? Prize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? Status { get; set; }
        public string? Result { get; set; }

    }
}
