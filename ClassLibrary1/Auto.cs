using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Auto : Veicolo
    {
        public int NumeroPosti { get; set; }

        public Auto(string targa, string marca, int kmPercorsi, float litriCarburanteConsumati, int numeroPosti) : base(
            targa, marca, kmPercorsi, litriCarburanteConsumati)
        {
            NumeroPosti = numeroPosti;
        }
        public override string GetDettagliCompleti()
        {
          return  $"Targa : {Targa}, Marca : {Marca} , Km Percorsi : {KmPercorsi} , litri del carburante consumati : {LitriCarburanteConsumati} , numero posti : {NumeroPosti}";
        }
    }
}
