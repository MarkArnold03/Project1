using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.ShapesData
{
    public class Shape
    {
        [Key]
        public int ShapeId { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }
        public double Side3 { get; set; }
        public string Typ { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public DateTime Date { get; set; }
    }
}
