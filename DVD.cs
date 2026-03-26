using System;

public class DVD : Document
{
    private string realisateur;
    private int duree;

    public DVD(int id, string titre, bool dispo, string realisateur, int duree)
        : base(id, titre, dispo)
    {
        if (duree <= 0)
            throw new Exception("Durée invalide");

        this.realisateur = realisateur;
        this.duree = duree;
    }

    public override void Afficher()
    {
        base.Afficher();
        Console.WriteLine("Réalisateur : " + realisateur);
        Console.WriteLine("Durée : " + duree);
    }

    public override string ToString()
    {
        return $"DVD [id={id}, titre={titre}, realisateur={realisateur}]";
    }
}