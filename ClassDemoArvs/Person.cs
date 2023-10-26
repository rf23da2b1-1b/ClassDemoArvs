using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoArvs
{
    public class Person
    {
        // instans felter
        protected string _navn;
        protected string _tlf;
        protected string _adresse;

        // properties
        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        // konstruktør
        public Person()
        {
            Navn = "";
            Tlf = "";
            Adresse = "";
        }

        public Person(string navn, string tlf, string adresse)
        {
            _navn = navn;
            _tlf = tlf;
            _adresse = adresse;
        }

        public override string ToString()
        {
            return $"{{{nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}, {nameof(Adresse)}={Adresse}}}";
        }
    }
}
