using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Joueur
    {
        public int numero;

        // 1. Méthode simple sans paramètres et sans retour
        public void DisplayInfo()
        {
            Console.WriteLine("Affichage des informations du joueur.");
        }

        // 2. Méthode avec paramètres mais sans retour
        public void SetName(string name)
        {
            Console.WriteLine($"Le nom du joueur est : {name}");
        }

        // 3. Méthode avec retour mais sans paramètres
        public int GetScore()
        {
            return 100;
        }

        // 4. Méthode avec paramètres et retour
        public int AddPoints(int currentScore, int pointsToAdd)
        {
            return currentScore + pointsToAdd;
        }

        // 5. Méthode statique
        public static int CalculateLevel(int score)
        {
            return score / 1000;
        }

        // 6. Méthode d'extension (nécessite d'être dans une classe statique et un autre contexte)
        // Cette méthode serait définie dans une classe statique externe, mais elle permet d'étendre la fonctionnalité d'une instance de Joueur.
        /*public static void ExtendMethod(this Joueur joueur)
        {
            Console.WriteLine("Méthode d'extension pour le joueur.");
        }*/


        // 7. Méthode avec paramètres optionnels
        public void DisplayDetails(int age,string name = "Joueur inconnu" )
        {
            Console.WriteLine($"Nom : {name}, Âge : {age}");
        }

        // 8. Méthode virtuelle
        public virtual void Play()
        {
            Console.WriteLine("Le joueur commence à jouer.");
        }


        // 9. Méthode avec des paramètres 'out'
        public void CalculateStats(int kills, int deaths, out float kda)
        {
            kda = (float) kills / deaths;
        }

        // 10. Méthode avec des paramètres 'ref'
        public void UpgradeLevel(ref int level)
        {
            level++;
        }

        // 11. Méthode avec des paramètres 'readonly ref'
        public void ChangeNumero(ref readonly int level)
        {
            //level++; //impossible de modifier level a lintereur de la methode et initialiser avan de passer le parametre
        }

        // 12. Méthode avec des paramètres 'in'
        public void ChangeNumero2(in int level)
        {
            //level++; //impossible de modifier level a lintereur de la methode et initialiser avan de passer le parametre
        }


        public void ChangeNumero(Joueur j)
        {
            j.numero = 19;
        }

        // surcharge
        // methode signature (name - parametres number - parametres type -parametres order)

        public void add(float a,int b)
        {
           
        }

        public void add(int a, float b)
        {

        }

        public void add(int a)
        {

        }

        public void add(double a)
        {

        }

        
        // had syntax kansta3mloha m3a les methode li fihom star wa7ed ou makandiroch return fles methode li kyretournew
        public bool IsEven(int a) => a % 2 == 0;




        // (methode locale) hadi kanste3mloha les methode li katstkheddam bwa7dha une autre methode aw ay block if{}for{}
        public int CalculateSum(int a, int b)
        {
            // Méthode locale
            int Add(int x, int y)
            {
                return x + y;
            }

            // Appel de la méthode locale
            return Add(a, b);
        }
 

    }
}
