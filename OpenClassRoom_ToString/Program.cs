using System;

namespace OpenClassRoom_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetVide monObjetVide = new ObjetVide();
            Chien chien = new Chien();
            chien.Prenom = "Medor";
            int age = 30;
            string prenom = "Nicolas";

            AfficherRepresentation(monObjetVide);
            AfficherRepresentation(chien);
            AfficherRepresentation(age);
            AfficherRepresentation(prenom);

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

        public void Aboyer()
        {
            Console.WriteLine("Wouaf !");
        }
    }

    public class ObjetVide
    {
    }
}
