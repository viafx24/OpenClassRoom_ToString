using System;

namespace OpenClassRoom_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetVide monObjetVide = new ObjetVide();
            Chien chien = new Chien();

            ChienMuet pauvreChien = new ChienMuet();
            pauvreChien.Aboyer();

            chien.Prenom = "Medor";
            int age = 30;
            string prenom = "Nicolas";

            AfficherRepresentation(monObjetVide);
            AfficherRepresentation(chien);
            AfficherRepresentation(age);
            AfficherRepresentation(prenom);


            Math math = new Math();
            int a = 5;
            int b = 6;
            int resultat = math.Addition(a, b);

            double c = 1.5;
            double d = 5.0;
            double resultatDouble = math.Addition(c, d); // ca compile, youpi



            Voiture voitureNicolas = new Voiture { Vitesse = 10, Marque = "Peugeot", Couleur = "Grise" };
            Voiture voitureJeremie = new Voiture { Vitesse = 10, Marque = "Peugeot", Couleur = "Grise" };
            if (voitureNicolas.Equals(voitureJeremie))
            {
                Console.WriteLine("Les objets ont les mêmes valeurs dans leurs propriétés");
            }


        }

        private static void AfficherRepresentation(object monObjetVide)
        {
            Console.WriteLine(monObjetVide.ToString());
        }
    }

    public class Animal
    {
        protected string prenom;

        public Animal()
        {
            prenom = "Marcel";
        }

        public void Respirer()
        {
            Console.WriteLine("Je suis " + prenom + " et je respire");
        }
    }


    public class Chien
    {
        public string Prenom { get; set; }

        public override string ToString()
        {
            return "Je suis un chien et je m'appelle " + Prenom;
        }

        public virtual void Aboyer()
        {
            Console.WriteLine("Wouaf !");
        }
    }

    public class ChienMuet : Chien
    {
        public override void Aboyer()
        {
            Console.WriteLine("...");
        }
    }

    public class ObjetVide
    {
    }

    public class Math
    {
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public double Addition(double a, double b)
        {
            return a + b;
        }

  
    }


    public class Voiture
    {
        public string Couleur { get; set; }
        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public override bool Equals(object obj)
        {
            Voiture v = obj as Voiture;
            if (v == null)
                return false;
            return Vitesse == v.Vitesse && Couleur == v.Couleur && Marque == v.Marque;
        }
    }

}
