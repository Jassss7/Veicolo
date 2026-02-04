using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class VeicoliCollection : KeyedCollection<string, Veicolo>
    {
        protected override string GetKeyForItem(Veicolo item)
        {
            return item.Targa;
        }
    }
}
