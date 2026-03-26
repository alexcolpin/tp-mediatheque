using System;

public class Emprunt
{
    private int id;
    private Document document;
    private Abonne abonne;
    private DateTime dateEmprunt;
    private DateTime dateRetourPrevue;

    public Emprunt(int id, Document doc, Abonne abo, DateTime dateE, DateTime dateR)
    {
        if (id <= 0)
            throw new Exception("Id invalide");

        if (!doc.Disponible)
            throw new Exception("Document non disponible");

        if (dateR < dateE)
            throw new Exception("Date incohérente");

        this.id = id;
        document = doc;
        abonne = abo;
        dateEmprunt = dateE;
        dateRetourPrevue = dateR;

        document.Disponible = false;
    }

    public bool EstEnRetard()
    {
        return DateTime.Now > dateRetourPrevue;
    }

    public int CalculerRetard()
    {
        if (!EstEnRetard())
            return 0;

        return (DateTime.Now - dateRetourPrevue).Days;
    }

    public void Retourner()
    {
        document.RendreDisponible();
    }

    public void Afficher()
    {
        Console.WriteLine($"Emprunt {id}");
        Console.WriteLine(document);
        Console.WriteLine(abonne);
        Console.WriteLine("Retour prévu : " + dateRetourPrevue.ToShortDateString());
    }

    public override string ToString()
    {
        return $"Emprunt [id={id}, doc={document.Titre}, abonne={abonne.Nom}]";
    }
}