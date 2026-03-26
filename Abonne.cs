using System;

public class Abonne
{
    private int id;
    private string nom;

    public Abonne(int id, string nom)
    {
        if (id <= 0)
            throw new Exception("Id invalide");

        if (string.IsNullOrEmpty(nom))
            throw new Exception("Nom vide");

        this.id = id;
        this.nom = nom;
    }

    public int Id { get { return id; } }
    public string Nom { get { return nom; } }

    public void Afficher()
    {
        Console.WriteLine($"Abonné {id} : {nom}");
    }

    public override string ToString()
    {
        return $"Abonne [id={id}, nom={nom}]";
    }
}