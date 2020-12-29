using System;

namespace OpenClassRoom_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetVide monObjetVide = new ObjetVide();
            Chien chien = new Chien();
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

    public class ObjetVide
    {
    }
}
