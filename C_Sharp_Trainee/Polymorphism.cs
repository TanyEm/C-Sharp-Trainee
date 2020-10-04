using System;

namespace C_Sharp_Trainee
{
    class Polymorphism
    {
        static void Main(string[] args)
        {
            // methods are identified not only by name, but also by parameters
            Overload overload = new Overload();
            overload.DisplayOverload(100);
            overload.DisplayOverload("method overloading");
            overload.DisplayOverload("method overloading", 100);

            overload.Display();

            object[] objArray = { 100, "Akhil", 200.300 }; //Массив 
            object obj = objArray; //Массив как объект
            Console.WriteLine("Массив");
            Overload.Display(objArray);
            Console.WriteLine("Массив, приведённый к объекту");
            Overload.Display((object)objArray); //Массив, приведённый к объекту
            Console.WriteLine("Массив, как объект");
            Overload.Display(obj);
            ///Почему бы не пойти глубже? :D
            Console.WriteLine("Массив, как объект, приведённый к массиву");
            Overload.Display((object[])obj); //Массив, как объект, приведённый к массиву
            Console.ReadKey();
        }
    }
}

public class Overload
{
    public void DisplayOverload(int a)
    {
        System.Console.WriteLine("DisplayOverload " + a);
    }
    public void DisplayOverload(string a)
    {
        System.Console.WriteLine("DisplayOverload " + a);
    }
    public void DisplayOverload(string a, int b)
    {
        System.Console.WriteLine("DisplayOverload " + a + b);
    }

    private string name = "Akhil";

    public void Display()
    {
        Display2(ref name, ref name);
        System.Console.WriteLine(name);
    }

    private void Display2(ref string x, ref string y)
    {
        System.Console.WriteLine(name);
        x = "Akhil 1";
        System.Console.WriteLine(name);
        y = "Akhil 2";
        System.Console.WriteLine(name);
        name = "Akhil 3";
    }

    public static void Display(params object[] objectParamArray)
    {
        foreach (object obj in objectParamArray)
        {
            Console.Write(obj.GetType().FullName + " ");
        }
        Console.WriteLine();

    }

    
}