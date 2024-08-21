using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


// ay 7aja public darori khasha documentation -  private optionnel 
namespace V__XML_Documentation
{
    /// <summary>
    /// class employeee
    /// </summary>
    /// <remarks>
    /// cette class peut gerer les mot de pass
    /// </remarks>
    internal class employee
    {
        public int Id { get; set; }
        /// <value> Nom de l'employee </value>
        public int Nom { get; set; }
        public int Prenom { get; set; }

        private string caractere = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private Random rand;

        public employee()
        {
            rand = new Random();
        }

        /// <summary>
        /// Generates a random password of the specified <paramref name="length"/>.
        /// </summary>
        /// <param name="length">The desired length of the generated password.</param>
        /// <returns>A randomly generated password string of the specified length.</returns>
        /// <example>
        /// <code>
        /// var password = GeneratePassword(10);
        /// Console.WriteLine(password); // Example output: "a8Fj2kL9z1"
        /// </code>
        /// </example>
        public string GeneratePassword(int length)
        {
            string code = "";
            int cmp = 0;
            while(cmp < length)
            {
                code += caractere[rand.Next(caractere.Length)];
                cmp++;
            }
            return code;
        }



        /// <summary>
        /// Trouve la valeur maximale dans une liste de nombres entiers.
        /// </summary>
        /// <param name="numbers">La liste de nombres entiers.</param>
        /// <returns>La valeur maximale trouvée dans la liste.</returns>
        /// <exception cref="ArgumentException">
        /// Lancée si la liste est vide.
        /// </exception>
        /// <example>
        /// <code>
        /// var numbers = new List<int> { 3, 5, 7, 2, 8 };
        /// int max = FindMax(numbers);
        /// Console.WriteLine(max); // Sortie : 8
        /// </code>
        /// </example>
        public int FindMax(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
                throw new ArgumentException("La liste ne doit pas être vide.");

            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }


        /// <summary>
        /// Traite une commande client en plusieurs étapes.
        /// </summary>
        /// <param name="order">L'objet commande à traiter.</param>
        /// <returns>Un booléen indiquant si la commande a été traitée avec succès.</returns>
        /// <remarks>
        /// Cette méthode suit les étapes suivantes :
        /// <list type="number">
        /// <item>
        /// <term>Validation</term>
        /// <description>Vérifie que la commande contient tous les éléments nécessaires.</description>
        /// </item>
        /// <item>
        /// <term>Paiement</term>
        /// <description>Débite le montant de la commande sur le compte du client.</description>
        /// </item>
        /// <item>
        /// <term>Expédition</term>
        /// <description>Prépare et expédie les articles commandés au client.</description>
        /// </item>
        /// <item>
        /// <term>Confirmation</term>
        /// <description>Envoie une confirmation de la commande au client par email.</description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <example>
        /// <code>
        /// var order = new Order { ... };
        /// bool success = ProcessOrder(order);
        /// Console.WriteLine(success ? "Commande réussie" : "Échec de la commande");
        /// </code>
        /// </example>
        /*
        public bool ProcessOrder(Order order)
        {
            // Implémentation de la méthode
            return true;
        }
        */


    }
}
