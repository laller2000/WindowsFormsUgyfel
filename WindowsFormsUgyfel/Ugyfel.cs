using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUgyfel
{
    class Ugyfel
    {
        string nev;
        string beosztas;
        int szulev;
        string nem;
        string helyseg;

        public Ugyfel(string nev, string beosztas, int szulev, string nem, string helyseg)
        {
            this.Nev = nev;
            this.Beosztas = beosztas;
            this.Szulev = szulev;
            this.Nem = nem;
            this.Helyseg = helyseg;
        }
        public Ugyfel(string sor)
        {
            string[] s = sor.Split(';');
            nev = s[0];
            beosztas = s[1];
            szulev = int.Parse(s[2]);
            nem = s[3];
            helyseg = s[4];
        }

        public string Nev { get => nev; set => nev = value; }
        public string Beosztas { get => beosztas; set => beosztas = value; }
        public int Szulev { get => DateTime.Now.Year-szulev; set => szulev = value; }
        public string Nem { get => nem; set => nem = value; }
        public string Helyseg { get => helyseg; set => helyseg = value; }

        public override string ToString()
        {
            return string.Format("{0} ({1})",nev,szulev);
        }

        public string Egysorba()
        {
            return string.Format($"{nev};{beosztas};{szulev};{nem};{helyseg}");
        }
        
    }
}
