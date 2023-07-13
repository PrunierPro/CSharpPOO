using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Dinosaur
    {

        private int _age;
        private string _espece;
        private int _nbPattes;
        private double _poids;
        private bool _peutVoler;

        public int Age { get => _age; set => _age = value; }
        public string Espece { get => _espece; set => _espece = value; }
        public int NbPattes { get => _nbPattes; set => _nbPattes = value; }
        public double Poids { get => _poids; set => _poids = value; }
        public bool PeutVoler { get => _peutVoler; set => _peutVoler = value; }

        public string RegimeAlimentair { get; set; }
        public string Nom { get; set; }


        public Dinosaur()
        {
            Nom = "Default";
            Age = default;
            Espece = "Default";
            PeutVoler = false;
        }
        public Dinosaur(string nom, int age, string espece, bool peutVoler)
        {
            Nom = nom;
            _age = age;
            _espece = espece;
            _peutVoler = peutVoler;
        }
    }
}
