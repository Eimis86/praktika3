using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBpraktika.Models
{
    public class Konfiguracija
    {
        public int Konfiguracijos_ID { get; set; }
        // papildomi id
        public int Variklio_ID { get; set; }
        public int Spalvos_ID { get; set; }
        public int Interjero_ID { get; set; }
        public int Ratu_ID { get; set; }
        public int Modelio_ID { get; set; }
        public double Galutine_Kaina { get; set; }

    }
}
