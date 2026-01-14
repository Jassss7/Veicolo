namespace ClassLibrary1
{
    public  abstract class Veicolo    
    {
        public string Targa { get; set; }
        public string Marca { get; set; }
        public int KmPercorsi { get; set; }
        public float LitriCarburanteConsumati { get; set; }
        public Veicolo(string targa, string marca, int kmPercorsi, float litriCarburanteConsumati)
        {
            Targa = targa;
            Marca = marca;
            KmPercorsi = kmPercorsi;
            LitriCarburanteConsumati = litriCarburanteConsumati;
        }

        public abstract string GetDettagliCompleti();
    }
}