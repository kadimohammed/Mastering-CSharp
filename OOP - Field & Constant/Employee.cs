using System;

namespace OOP___Field___Constant
{
    // public et internal (default)
    // public sealed class Employee => public et sealed : La classe ne peut pas être dérivée
    // file le type déclaré est visible uniquement dans le fichier source actuel. Les types de fichiers délimités sont généralement utilisés pour les générateurs de sources.

    public class Employee // public : La classe est accessible depuis n'importe où dans le code
    {
        // Champ constant
        public const int ConstantField = 100; // const : Valeur constante assignée lors de la déclaration et ne peut pas être changée
         
        // Champ readonly
        public readonly int ReadonlyField; // readonly : Peut être assigné une seule fois dans le constructeur

        public virtual int VirtualProperty { get; set; } // virtual : Propriété qui peut être remplacée dans une classe dérivée


        // Modificateurs d'accès pour les membres de classe
        public int PublicField; // Accessible partout
        private int PrivateField; // Accessible uniquement au sein de cette classe
        protected int ProtectedField; // Accessible au sein de cette classe et des classes dérivées
        internal int InternalField; // Accessible uniquement dans le même assembly
        protected internal int ProtectedInternalField; // Accessible dans le même assembly et par les classes dérivées
        private protected int PrivateProtectedField; // Accessible dans le même assembly et par les classes dérivées dans le même assembly

        // Propriétés avec accesseurs
        public int PublicProperty { get; set; } // Propriété publique
        private int PrivateProperty { get; set; } // Propriété privée
        protected int ProtectedProperty { get; set; } // Propriété protégée
        internal int InternalProperty { get; set; } // Propriété interne
        protected internal int ProtectedInternalProperty { get; set; } // Propriété protégée interne
        private protected int PrivateProtectedProperty { get; set; } // Propriété protégée interne

        

        // Méthodes avec différents modificateurs d'accès
        public void PublicMethod() { } // Accessible partout
        private void PrivateMethod() { } // Accessible uniquement au sein de cette classe
        protected void ProtectedMethod() { } // Accessible au sein de cette classe et des classes dérivées
        internal void InternalMethod() { } // Accessible uniquement dans le même assembly
        protected internal void ProtectedInternalMethod() { } // Accessible dans le même assembly et par les classes dérivées
        private protected void PrivateProtectedMethod() { } // Accessible dans le même assembly et par les classes dérivées dans le même assembly

        // Méthode statique
        public static void StaticMethod() { } // static : La méthode appartient à la classe plutôt qu'à une instance

        // Méthode virtuelle (exemple)
        public virtual void VirtualMethod() // virtual : La méthode peut être remplacée dans une classe dérivée
        {
            Console.WriteLine("Base Employee Method");
        }

        // Méthode de remplacement (exemple)
        public override string ToString() // override : La méthode remplace la méthode de la classe de base Object
        {
            return $"PublicField: {PublicField}, ReadonlyField: {ReadonlyField}, VirtualProperty: {VirtualProperty}";
        }
    }

    public class DerivedClass : Employee
    {
        public sealed override void VirtualMethod()
        {
            Console.WriteLine("DerivedClass VirtualMethod");

        }
    }


    /*public class DerivedClass1
    {
        public void VirtualMethod()
        {
            Employee e1 = new Employee();
            Console.WriteLine("DerivedClass VirtualMethod");

        }
    }*/

}