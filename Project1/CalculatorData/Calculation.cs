using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.CalculatorData
{
    public class Calculation
    {
        [Key]
        public int ID { get; set; }
        public double Tal1 { get; set; }
        public double Tal2 { get; set; }
        public string Operator { get; set; }
        public double Result { get; set; }
        public DateTime Date { get; set; }
    }
}
