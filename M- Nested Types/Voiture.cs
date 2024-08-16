using static M__Nested_Types.Voiture;

namespace M__Nested_Types
{
    public class Voiture
    {
        public string Marque { get; set; }
        public string Modele { get; set; }


        // Méthode privée qui crée une instance de la classe Moteur imbriquée.
        private Moteur CreerMoteur()
        {
            return new Moteur { Cylindres = 4, TypeCarburant = "Essence" };
        }

        // Classe imbriquée privée : 
        // Accessible uniquement à l'intérieur de la classe parent Voiture.
        private class Moteur
        {
            public int Cylindres { get; set; }
            public string TypeCarburant { get; set; }

            public Moteur()
            {
                Console.WriteLine("constructor moteur");
            }

            // La méthode peut créer une instance de la classe Moteur
            // car elle est définie comme privée dans la même classe.
            void methode()
            {
                Moteur a = new Moteur();
                a.Cylindres = 500; // La classe Moteur peut accéder à ses propres attributs privés.
            }
        }

        // Classe imbriquée protégée :
        // Accessible dans Voiture et dans toutes les classes dérivées de Voiture.
        protected class Transmission
        {
            public string TypeTransmission { get; set; }

            public Transmission()
            {
                Console.WriteLine("constructor transmission");
            }

            // Une méthode dans la classe imbriquée Transmission
            // Cette méthode peut accéder aux attributs et méthodes de Transmission.
            void MethodeTransmission()
            {
                Transmission t = new Transmission();
                t.TypeTransmission = "Automatique";
            }
        }
    }

    // Classe dérivée de Voiture
    public class VoitureSport : Voiture
    {
        public VoitureSport()
        {
            Console.WriteLine("constructor voiture sport");

            // Ici, nous pouvons accéder à la classe imbriquée Transmission
            // car elle est définie comme protégée dans la classe parent Voiture.
            Transmission sportTransmission = new Transmission();
            sportTransmission.TypeTransmission = "Manuelle";

            // Cependant, nous ne pouvons pas accéder à la classe Moteur
            // car elle est définie comme privée dans la classe parent Voiture.
            // Moteur moteur = new Moteur(); // Ceci provoquerait une erreur.
        }
    }
}
