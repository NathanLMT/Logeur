using System;
using System;
using Puissance4.Player;


namespace Puissance4
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            IJoueur joueur1, joueur2;
            while (true)
            {
                Console.WriteLine("Bienvenue dans puissance 4");
                Loger.WriteLine($"Partie lancer", "INFO");
                Console.WriteLine("Quel est le nom de joueur 1 ?");
                string joueur1Name = Console.ReadLine();
                Loger.WriteLine($"Non du joueur 1 est maintenant égal à : {joueur1Name}", "INFO");
                joueur1 = new Joueur1(joueur1Name);
                Console.WriteLine("Quel est le nom de joueur 2 ?");
                string joueur2Name = Console.ReadLine();
                Loger.WriteLine($"Non du joueur 2 est maintenant égal à : {joueur2Name}", "INFO");
                joueur2 = new Joueur2(joueur2Name);
                
                MoteurDeJeu moteur = new MoteurDeJeu(joueur1,joueur2);
                while (moteur.QuiAGagner() == string.Empty)
                {
                    //Afficher board
                    Console.WriteLine(moteur.Affichage());
                    // Affiche qui joue
                    Console.WriteLine($"{moteur.QuiJoue()} joue");
                    Console.WriteLine("Choisissez une colonne 1 à 7");
                    Loger.WriteLine($"{moteur.QuiJoue()} joue", "INFO");

                    //Joue
                    string numColonne = Console.ReadLine();
                    bool verif = IsNumeric(numColonne);
                    if(verif == true)
                    {
                        Loger.WriteLine($"Choix colonne numero {numColonne}", "INFO");
                        moteur.Jouer(int.Parse(numColonne));

                    }
                    else
                    {
                        Loger.WriteLine($"Le choix de la colonne n'est pas un nombre", "ERREUR");
                        break;
                    }

                        
                   
                    
                       
                    
                   
                    
                }
                Console.WriteLine($"{moteur.QuiAGagner()} a gagné");
                Loger.WriteLine($"{moteur.QuiJoue()} a gagné", "INFO");
                
                Console.WriteLine("Voulez-vous rejouez ? (y/N)");
                if (Console.ReadLine().ToLowerInvariant() != "y")
                    break;
            }
        }
            public static bool IsNumeric(string numColonne)
            {
                try
                {
                    int.Parse(numColonne);
                
                return true;
                }
                catch
                {
               
                return false;
                }
            }
        }
}
