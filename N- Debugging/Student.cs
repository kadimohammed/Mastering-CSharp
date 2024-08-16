using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace N__Debugging
{
    // Par convention, les structures (structs) en C# sont généralement immutables. 
    internal struct Student : test  // si structure et de type readonly tous les attribut interne etre readoly par obligation (les class ne preds pas le type readonly)
    {
        // dans c# 9 la difference entre class et struct
        // struct il accept pas le constructeur sans parametre mais il est difini par clr.mais il accept les constructeur dinitialisation
        // struct ne accept pas linitialisation des attributs.

        // c# 9 et 12
        // la structure il acceppt pas de creer le distructeur
        // ne support pas lheritage mais la structure il est implicitement herite de la class mere "object"
        // il support limplementation des interfaces
        // il est stocker dans la pile (stack) ==> value type
        // Il est recommandé d'utiliser uniquement des types de valeurs (value types) dans les structures et de ne pas dépasser 16 octets.
        // l'utilisation du mot-clé new n'est pas nécessaire lorsque la structure ne contient aucun attribut personnalisé et que tous les attributs sont initialisés.

        // atribut
        public string _nom = "kadi";

        //prop
        //public int Id { get; set; } = 100;

        //constructeur
        public Student()
        {
            this._nom = "meed";
        }


        //methode
        public void Show()
        {
            Console.WriteLine(_nom);
        }




        //ne support pas methode virtual ou protected car il support pas l'heritage
        /*protected virtual void getMessage()
        {
            Console.WriteLine("Hello "+_nom);
        }*/



        //destucteur nexist pas sur les structures
        /*~Stdent()
        {
            Console.WriteLine(Id);
        }*/


    }
}
