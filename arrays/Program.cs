
// single dimention array -----------------------------------------------


// declaration 
string[] teams1 = new string[4];

// affectaion
teams1[0] = "morocco";
teams1[1] = "france";
teams1[2] = "italie";
teams1[3] = "espagne";

print(teams1);

// methode 2 initialisation 

string[] teams2 = new string[4]
{
    "usa",
    "chine",
    "algeria",
    "brazil",
};
print(teams2);


// methode 3 initialisation 
string[] teams3 =
{
    "egype",
    "cameron",
    "almagne",
    "argentine",
};
print(teams3);


// methode 3 initialisation 
var teams4 = new string[]
{
    "saudi",
    "japon",
    "urugway",
    "england",
};
print(teams4);



// multi dimention array -----------------------------------------------

int[,] Mar_Int1 = new int[2, 3] 
{ 
    { 1, 2, 3 }, 
    { 4, 5, 6 } 
};

Mar_Int1[0,0] = 5;


int[,] Mar_Int2 = {
    { 1, 2, 3 },
    { 4, 5, 6 } 
};


var Mar_Int3 = new int[2, 3] { 
    { 1, 2, 3 }, 
    { 4, 5, 6 }
};


// jagged array (array interieur array) // high performance ------------------------------------------------

int[][] jaggedArray1 = new int[][] { 
    new int[] { 1, 2, 3, 4, 5 } 
};

jaggedArray1[0][2] = 4;


int[][] jaggedArray2 = new int[][]
{
    new int[] { 1, 2 },
    new int[] { 3, 4, 5 },
    new int[] { 6, 7, 8, 9 },
    new int[] { 10 },
    new int[] { 11, 12, 13 }
};



int[][] jaggedArray3 = new int[3][]
{
    new int[2] { 1, 2 },
    new int[3] { 3, 4, 5 },
    new int[] { 6, 7, 8, 9 },
};


// Initialiser un tableau d'entiers
int[] tableau = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


// Utilisation de la notation ..2 (de 0 jusqu'à l'index 2)
var plage = tableau[..2]; // kycriyi tableaux jdid "plage" la 3ala9a b "tableau"
//var plade_ = tableau.AsSpan(0, 2);


// Utilisation de la notation 2.. (de l'index 2 jusqu'à la fin)
var plage1 = tableau[2..]; //var plage__ = tableau.AsSpan(2, tableau.Length - 1);



// Utilisation de la notation 1..^2 (de l'index 1 jusqu'à l'avant-dernier)
var plage2 = tableau[1..^2];


// Utilisation de la notation 1..5 (de l'index 1 à l'index 4)
var plage3 = tableau[1..5];


// Utilisation de la notation 1..5 (de l'index 1 à l'index 4)
Range rr = 1..5;
var plage4 = tableau[rr];
print(plage4);















void print<T>(T[] tab)
{
    string s = "{ ";
    for(int i=0; i < tab.Length; i++)
    {
        s +=  tab[i];
        s += i < tab.Length-1 ? ", " : " }";
    }
    Console.WriteLine(s);
}
