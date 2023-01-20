using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Rock_Paper_ScissorsData
{
        public enum Result
        {
            Win,
            Loss,
            Draw
        }

        public enum Choice
        {
            Rock,
            Paper,
            Scissor
        }
        public class GameResult
        {
            [Key]
            public int Id { get; set; }
            [Column(TypeName = "nvarchar(50)")]
            public Choice UserChoice { get; set; }
            [Column(TypeName = "nvarchar(50)")]
            public Choice ComputerChoice { get; set; }
            [Column(TypeName = "nvarchar(50)")]
            public Result Result { get; set; }
            public DateTime Date { get; set; }
            public double WinRate { get; set; }
        }

}
