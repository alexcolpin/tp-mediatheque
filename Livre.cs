using System;

public class Livre : Document
{
    private string auteur;
    private int nombrePages;

    public Livre(int id, string titre, bool dispo, string auteur, int nbPages)
        : base(id, titre, dispo)
    {
        if (nbPages <= 0)
            throw new Exception("Nombre de pages invalide");

        this.auteur = auteur;
        this.nombrePages = nbPages;
    }

    public string Auteur { get { return auteur; } set { auteur = value; } }
    public int NombrePages { get { return nombrePages; } set { nombrePages = value; } }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine("Auteur : " + auteur);
        Console.WriteLine("Pages : " + nombrePages);
    }

    public override string ToString()
    {
        return $"Livre [id={id}, titre={titre}, auteur={auteur}]";
    }
}