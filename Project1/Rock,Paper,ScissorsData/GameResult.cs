using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Rock_Paper_ScissorsData
{
    public class GameResult
    {
        [Key]
        public int Id { get; set; }
        public string UserChoice { get; set; }
        public string ComputerChoice { get; set; }
        public string Result { get; set; }
        public DateTime Date { get; set; }
        public double WinRate { get; set; }
    }
}
