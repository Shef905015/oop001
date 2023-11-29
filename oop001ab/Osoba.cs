using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop001ab
{
    internal class Osoba
    {

        string ime, prezime;
        int godinaRodjenja, visina, tezina;
        char spol;

        public void setIme(string ime)
        {
            this.ime = ime;
        }
        public void setPrezime(string prezime)
        {
            this.prezime = prezime;
        }
        public void setGodinaRodjenja(int godinaRodjenja)
        {
            this.godinaRodjenja = godinaRodjenja;
        }
        public void setVisina(int visina)
        {
            this.visina = visina;
        }
        public void setTezina(int tezina)
        {
            this.tezina = tezina;
        }
        public void setSpol(char spol)
        {
            this.spol = spol;
        }
        //-----------------------------------------------
        public string getIme()
        {
            return this.ime;
        }
        public string getPrezime()
        {
            return this.prezime;
        }
        public int getGodinaRodjenja()
        {
            return this.godinaRodjenja;
        }
        public int getVisina()
        {
            return this.visina;
        }
        public int getTezina()
        {
            return this.tezina;
        }
        public char getSpol()
        {
            return this.spol;
        }

        public override string ToString()
        {
            string ispis = "Ime i prezime:  " + this.getIme() + " " + this.getPrezime() + "\n"
            + "Godina rođenja: " + this.getGodinaRodjenja() + "\n"
            + "Visina: " + this.getVisina() + " cm\n"
            + "Težina " + this.getTezina() + " kg\n"
            + "Spol: " + this.getSpol() + "\n";
            return ispis;
        }

        public Osoba(String ime, String prezime, int godinaRodjenja, int visina, int tezina, char spol)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godinaRodjenja = godinaRodjenja;
            this.visina = visina;
            this.tezina = tezina;
            this.spol = spol;
        }

        public Osoba() { }
    }
}
