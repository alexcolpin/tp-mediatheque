using System;

public class Document
{
    protected int id;
    protected string titre;
    protected bool disponible;

    // Constructeur
    public Document(int id, string titre, bool disponible)
    {
        if (id <= 0)
            throw new Exception("Id invalide");

        if (string.IsNullOrEmpty(titre))
            throw new Exception("Titre vide");

        this.id = id;
        this.titre = titre;
        this.disponible = disponible;
    }

    // Getters / Setters
    public int Id { get { return id; } set { id = value; } }
    public string Titre { get { return titre; } set { titre = value; } }
    public bool Disponible { get { return disponible; } set { disponible = value; } }

    // Méthodes
    public virtual void Afficher()
    {
        Console.WriteLine("Id : " + id);
        Console.WriteLine("Titre : " + titre);
        Console.WriteLine("Disponible : " + disponible);
    }

    public override string ToString()
    {
        return $"Document [id={id}, titre={titre}, disponible={disponible}]";
    }

    public void RendreDisponible()
    {
        disponible = true;
    }
}