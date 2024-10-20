using BestPractices.DesignPatterns.Creationals;
using BestPractices.DesignPatterns.Structures;

Singleton singleton1 = Singleton.GetInstance(); //new Singleton();
Singleton singleton2 = Singleton.GetInstance(); //new Singleton();

AlumnoRepository repository = new AlumnoRepository();


Console.WriteLine($"GetHashCode singleton1: {singleton1.GetHashCode().ToString()}");
Console.WriteLine($"GetHashCode singleton2: {singleton2.GetHashCode().ToString()}");


Console.ReadLine();