using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Camion : Veicolo
    {
        public int CapacitaCarico { get; set; }

        public Camion(string targa, string marca, int kmPercorsi, float litriCarburanteConsumati, int numeroPosti) : base(
            targa, marca, kmPercorsi, litriCarburanteConsumati)
        {
            CapacitaCarico = numeroPosti;
        }
        public override string GetDettagliCompleti()
        {
            return $"Targa : {Targa}, Marca : {Marca} , Km Percorsi : {KmPercorsi} , litri del carburante consumati : {LitriCarburanteConsumati} , Capacita Carico : {CapacitaCarico}";
        }
    }
}
