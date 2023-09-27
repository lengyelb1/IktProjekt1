using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdatPanel.Objects
{
    public class Record
    {
        [DataMember]
        public int? Id { get; set; }

    }

    [DataContract]

    public class Felhasznalo : Record
    {
        [DataMember]

        public string LoginNev { get; set; }

        [DataMember]

        public string HASH { get; set; }

        [DataMember]

        public string SALT { get; set; }

        [DataMember]

        public string Nev { get; set; }

        [DataMember]

        public byte Jog { get; set; }

        [DataMember]

        public bool Aktiv { get; set; }

        [DataMember]

        public string Email { get; set; }

        [DataMember]

        public string ProfilKep { get; set; }



        public override string ToString()
        {
            return $"Id: {Id}\nLogin név: {LoginNev}\nHASH: {HASH}\nSALT: {SALT}\nNév: {Nev}\nJog: {Jog}\nAktív: {(Aktiv ? "Igen" : "Nem")}\nE-mail: {Email}\nProfilkép utvonala: {ProfilKep}";
        }

    }
}
