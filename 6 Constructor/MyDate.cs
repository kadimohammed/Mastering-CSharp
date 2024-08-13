namespace _6_Constructor
{
    public class MyDate
    {
        // private int day;  private int _day;
        public static int NombraInstance;

        private static readonly int[] _dayToMonth366 = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private static readonly int[] _dayToMonth365 = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public int Day;
        public int Month;
        public int Year;



        // appel un seul fois avant de creer la premiere instance
        // constructeur static il contien pas les parametres
        // utiliser just les membre static
        static MyDate() 
        {
            MyDate.NombraInstance = 0;
        }

        public MyDate()
        {
            Day = 1;
            Month = 1;
            Year = 1;
        }

        public MyDate(int day, int month, int year)
        {
            bool isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

            if (year > 0 && year <= 9999 && month > 0 && month <= 12)
            {
                int[] DayToMonth = isLeap ? _dayToMonth366 : _dayToMonth365;

                if (day <= DayToMonth[month] && day > 0)
                {
                    this.Day = day;
                    this.Month = month;
                    this.Year = year;
                }
                else
                {
                    throw new Exception("La date invalid");
                }
            }
            else
            {
                throw new Exception("La date invalid");
            }
        }

  

        public MyDate(int year) : this(01, 01, year)
        {

        }

        // surcharge de constructor
        public MyDate(int month, int year) : this(01, month, year)
        {

        }


        // on utilise cette methode lorsque tous les constructor est priver
        public static MyDate Create(int day, int month, int year)
        {
            return new MyDate(day, month, year);
        }

        public string GetDate()
        {
            return $"{this.Day.ToString().PadLeft(2, '0')}/{this.Month.ToString().PadLeft(2, '0')}/{this.Year.ToString().PadLeft(4, '0')}";
        }



    }
}
