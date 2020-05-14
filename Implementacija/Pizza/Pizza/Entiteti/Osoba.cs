﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Entiteti
{
    public class Osoba
    {
        public virtual int Id_osoba { get; protected set; }

        public virtual string Ime { get; set; }

        public virtual string Prezime { get; set; }

        public virtual string Ulica { get; set; }

        public virtual int Broj { get; set; }

        public virtual string Grad { get; set; }

        public virtual string Drzava { get; set; }

        public virtual char FZaposleni { get; protected set; }

        public virtual string Jmbg { get; set; }

        public virtual DateTime Datum_rodjenja { get; set; }

        public virtual char FPrimalac_porudzbine { get; protected set; }

        public virtual char FDostavljac { get; protected set; }

        public virtual char FKupac { get; protected set; }

        public virtual DateTime Datum_prve_porudzbine { get; set; }

        public virtual char FBonus_program { get; protected set; }

        public virtual int Br_bodova { get; set; }

        //many-to-one Osoba-Vozilo
        public virtual Vozilo DuziVozilo { get; set; }

        //one-to-many Osoba-Vozilo
        public virtual IList<Porudzbina> Porudzbine { get; set; }

        //one-to-many Osoba-BrTelefona
        public virtual IList<BrTelefona> BrojeviTelefona { get; set; }

        public Osoba()
        {
            Porudzbine = new List<Porudzbina>();

            BrojeviTelefona = new List<BrTelefona>();
        }

    }
}
