using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBpraktika.Models
{
    public class Variklis
    {
        public int Variklio_ID { get; set; }
        public string Variklio_Pavadinimas { get; set; }
        public int Kuro_ID { get; set; }
        public int Pavaru_Tipo_ID { get; set; }
        public double Variklio_Kaina { get; set; }

    }
}
