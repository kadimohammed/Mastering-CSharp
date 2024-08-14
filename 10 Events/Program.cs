using _10_Events;


// exercice 1

Cafetiere maCafetiere = new Cafetiere();


maCafetiere.CafePret += (obj, arg) =>
{
    Cafetiere c = (Cafetiere)obj;
    Console.WriteLine("Le café est prêt ! Vous pouvez le servir." + c.id);
    Console.WriteLine(arg.Message + " " + arg.Value);
};

maCafetiere.CafePret += (obj, arg) =>
{
    Console.WriteLine("bienvenu chez cafe.");
};


// ladiference entre delegate et events :
//delegate += et -= et =
//delegate += et -=


/*maCafetiere.func += (obj) =>
{
    Console.WriteLine("1 "+obj.Message);
};

maCafetiere.func += (obj) =>
{
    Console.WriteLine("2");
};*/


maCafetiere.PreparerCafe();

Console.ReadLine();




// exercice 2


Alarme al = new Alarme();
al.Alarm += (obj,t) =>
{
    Console.WriteLine("temperature est "+t.tempErature);
};


al.SurveillerTemperature(12);
