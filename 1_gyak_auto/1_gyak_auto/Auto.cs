using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_gyak_auto
{
    class Auto
    {
        private string gyarto;
        private string tipus;
        //futasi ideju konstans
        private readonly int evjarat;
        //forditasi ideju konstans
        private string motortipus;
        private string uzemanyag;
        private double atlagfogyaasztas;
        public Auto(string gyarto, string tipus, int evjarat, string motortipus)
        {
            this.gyarto = gyarto;
            this.tipus = tipus;
            this.evjarat = evjarat;
            
            this.uzemanyag = "benzin";
            switch (motortipus)
            {
                case "1.4":
                    this.atlagfogyaasztas = 6.8;
                    break;
                case "1.8":
                    this.atlagfogyaasztas = 7.5;
                    break;
                default:
                    break;
            }
        }

        public string Atlagfogyasztas
        {
            get { return atlagfogyaasztas; }
            set { atlagfogyaasztas = value; }
        }



        public string Gyarto
        {
            get { return gyarto; }
            set { gyarto = value; }
        }


        public string Tipus
        {
            get
            {
                return tipus;
            }

            //set{tipus = value;}
        }

        public string Uzemanyag
        {
            get
            {
                return uzemanyag;
            }

            set
            {
                uzemanyag = value;
            }
        }
        public double Fogyasztas(double uzemanyag, int tavolsag)
        {
            return uzemanyag / tavolsag * 100;
        }
        public bool atlagFogyasztas(Auto gepjarmu, double uzemanyag, int tavolsag)
        {
            return gepjarmu.Fogyasztas(uzemanyag, tavolsag) <= atlagfogyaasztas;
        }
    }
}
