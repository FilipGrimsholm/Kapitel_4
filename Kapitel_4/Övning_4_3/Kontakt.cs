using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_4_3
{
    public class Kontakt
    {
        public string _förnamn;
        public string _efternamn;
        public string _epost;
        public string _telefonnummer;

        public Kontakt(string förnamn, string efternamn, string epost, string telefonnummer)
        {
            this._förnamn = förnamn;
            this._efternamn = efternamn;
            this._epost = epost;
            this._telefonnummer = telefonnummer;
        }

        public override string ToString()
        {
            return _förnamn + " " + _efternamn;
        }
    }
}
