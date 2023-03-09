using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.EntityLayer.Concrete
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string Brand { get; set; }
        public int ModelYear { get; set; }
        public int Km { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
    }
}
