namespace Exercice1.Classes
{
    internal class Chaise
    {

        private int _nbPieds;
        private string _materiaux;
        private string _couleur;

        public int NbPieds { get => _nbPieds; set => _nbPieds = value; }
        public string Materiaux { get => _materiaux; set => _materiaux = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }

        public Chaise()
        {
            NbPieds = 4;
            Materiaux = "Bois";
            Couleur = "Marron";
        }

        public Chaise(int nbPieds, string materiaux, string couleur)
        {
            NbPieds = nbPieds;
            Materiaux = materiaux;
            Couleur = couleur;
        }

        public void Afficher()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Je suis une Chaise, avec {NbPieds} pieds en {Materiaux} et de couleur {Couleur}";
        }
    }
}
