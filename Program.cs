namespace tp_mediatheque;

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        try
        {
            // Documents
            Livre l1 = new Livre(1, "1984", true, "Orwell", 300);
            DVD d1 = new DVD(2, "Inception", true, "Nolan", 120);

            List<Document> docs = new List<Document>();
            docs.Add(l1);
            docs.Add(d1);

            foreach (Document d in docs)
            {
                d.Afficher();
                Console.WriteLine(d);
                Console.WriteLine("------");
            }

            // Abonnés
            Abonne a1 = new Abonne(1, "Alice");

            Dictionary<int, Abonne> abonnés = new Dictionary<int, Abonne>();
            abonnés.Add(a1.Id, a1);

            Console.WriteLine(abonnés[1]);

            // Emprunt
            Emprunt e1 = new Emprunt(
                1,
                l1,
                a1,
                DateTime.Now,
                DateTime.Now.AddDays(-2) // en retard
            );

            e1.Afficher();
            Console.WriteLine("En retard ? " + e1.EstEnRetard());
            Console.WriteLine("Jours de retard : " + e1.CalculerRetard());

            // Retour
            e1.Retourner();
            Console.WriteLine("Disponible après retour : " + l1.Disponible);
        }
        catch (Exception e)
        {
            Console.WriteLine("Erreur : " + e.Message);
        }
    }
}