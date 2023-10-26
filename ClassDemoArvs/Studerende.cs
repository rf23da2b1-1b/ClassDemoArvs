using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoArvs
{
    public class Studerende : Person
    {
        // instans felt
        private string _semester;

        // property
        public string Semester
        {
            get { return _semester; }
            set { _semester = value; }
        }



        // kostruktør
        public Studerende():base()
        {
            _semester = "";
        }

        public Studerende(string navn, string tlf, string adresse, string semester):
            base(navn,tlf,adresse)
        {
            _semester = semester;

            _navn = "Peter";
        }

        public override string ToString()
        {
            return $"{{{nameof(Semester)}={Semester}, {nameof(Navn)}={Navn}, {nameof(Tlf)}={Tlf}, {nameof(Adresse)}={Adresse}}}";
        }
    }
}
