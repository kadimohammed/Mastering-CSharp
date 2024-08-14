using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H__Operator_Overloading
{
    internal class Money
    {
        // a + b  // binaire operator
        // !a  // unaire operator

        public string Libelle { get; set; }
        public int Amount { get; set; }


        public Money(string Libelle, int Amount)
        {
            this.Libelle = Libelle;
            this.Amount = Amount;
        }




        // Opérateurs arithmétiques  //////////////////////////////////////////////

        public static Money operator +(Money a, Money b)
        {
            return new Money("new money",a.Amount+b.Amount);
        }


        public static Money operator -(Money a, Money b)
        {
            return new Money("new money", a.Amount - b.Amount);
        }


        public static Money operator *(Money a, Money b)
        {
            return new Money("new money", a.Amount * b.Amount);
        }


        public static Money operator /(Money a, Money b)
        {
            return new Money("new money", a.Amount / b.Amount);
        }


        // Opérateurs de comparaison /////////////////////////////////////////////////////

        public static bool operator == (Money a, Money b)
        {
            return a.Amount == b.Amount;
        }

        public static bool operator !=(Money a, Money b)
        {
            return a.Amount != b.Amount;
        }

        public static bool operator >(Money a, Money b)
        {
            return a.Amount > b.Amount;
        }


        public static bool operator <(Money a, Money b)
        {
            return a.Amount < b.Amount;
        }


        public static bool operator <=(Money a, Money b)
        {
            return a.Amount <= b.Amount;
        }

        public static bool operator >=(Money a, Money b)
        {
            return a.Amount <= b.Amount;
        }

        public static Money operator %(Money a, Money b)
        {
            return new Money("new money", a.Amount % b.Amount);
        }


        // Opérateurs unaires //////////////////////////////////////////////////////////////////

        // Négation
        public static Money operator !(Money a)
        {
            return new Money("new money", -1* a.Amount);
        }

        // Complément binaire
        public static Money operator ~(Money a)
        {
            return new Money("bitwise NOT", ~a.Amount);
        }

        


        // Opérateurs bitwise /////////////////////////////////////////////////////////////////

        public static Money operator &(Money a, Money b)
        {
            return new Money("Bitwise AND", a.Amount & b.Amount);
        }

        
        public static Money operator |(Money a, Money b)
        {
            return new Money("Bitwise OR", a.Amount | b.Amount);
        }


        public static Money operator ^(Money a, Money b)
        {
            return new Money("Bitwise XOR", a.Amount ^ b.Amount);
        }



        /*public static bool operator |(Money a, Money b)
        {
            return a.Amount>0 || b.Amount>0;
        }*/



        // true false operator ////////////////////////////////////////////////////////////

        public static bool operator true(Money a)
        {
            return a.Amount > 0;
        }

        // Surcharge de l'opérateur false
        public static bool operator false(Money a)
        {
            return a.Amount <= 0;
        }


        // Opérateurs d'incrémentation et de décrémentation //////////////////////////////////////////////////////////////////


        public static Money operator ++(Money a)
        {
            return new Money("new money", a.Amount + 10);
        }

        public static Money operator --(Money a)
        {
            return new Money("new money", a.Amount - 10);
        }



        // Opérateur de conversion explicite /////////////////////////////////////////////////////////////////////

        // Money c = new Money("din", 1);
        // int d = (int) c;
        /*public static explicit operator int(Money a)
        {
            return a.Amount;
        }*/


        //Money d = (Money)12;
        /*public static explicit operator Money(int amount)
        {
            return new Money("Converted", amount);
        }*/


        // Opérateur de conversion implicite  /////////////////////////////////////////////////////////////////////

        //Money d = 100;
        public static implicit operator Money(int amount)
        {
            return new Money("Implicit", amount);
        }


        // Money c = new Money("din", 1);
        // int d = c;
        public static implicit operator int(Money a)
        {
            return a.Amount;
        }





        // Opérateurs de décalage /////////////////////////////////////////////////////////////////////


        public static Money operator <<(Money a, int shift)
        {
            return new Money("Left Shift", a.Amount << shift);
        }

        public static Money operator >>(Money a, int shift)
        {
            return new Money("Right Shift", a.Amount >> shift);
        }






        //////////////////////////////////////////////////////////////////////////


        public override string ToString()
        {
            return this.Libelle +" : "+this.Amount;
        }


    }
}
