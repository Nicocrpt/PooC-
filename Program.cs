
using System;

Utilisateur utilisateur = new Utilisateur("john", "doe", "test123", "john@doe");

utilisateur.Nom = "test";

Console.WriteLine(utilisateur.Nom);

Console.WriteLine(utilisateur.motDePasse);

utilisateur.motDePasse = "chgtMdp";

Console.WriteLine(utilisateur.motDePasse);

utilisateur.motDePasse = "cgtMdp12";

Console.WriteLine(utilisateur.motDePasse);


public class Utilisateur {

    public string? Nom 
    {
        get; 
        set;
    } 
    public string? Prenom {get; set;}
    private string? _Mdp {get; set;}

    public string? motDePasse {
        get {
            return _Mdp;
        }
        set {
            if (verifyPassword(value)) {
                _Mdp = value;
            } else {
                Console.WriteLine("Le mot de passe est non valide");
            }
        }
    }
    public string? Mail {get; set;}
    
    public Utilisateur(string name, string firstname, string password, string email)
    {
        Nom = name;
        Prenom = firstname;
        _Mdp = password;
        Mail = email;
    }

    public bool verifyPassword(string password)
    {
        bool letter = false;
        bool number = false;

        foreach (char c in password)
        {
            if (Char.IsLetter(c) && !letter) {
                letter = true;
            } else if (Char.IsDigit(c) && !number) {
                number = true;
            }
            if (letter && number){
                return true;
            }
        }
        return letter && number ? true : false ;
    }
}