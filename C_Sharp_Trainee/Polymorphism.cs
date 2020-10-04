using System;

namespace C_Sharp_Trainee
{

    public class Overload
    {
        // methods are identified not only by name, but also by parameters
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


        /*
         * We can pass the same reference parameters as many times as we want. 
         * In the Display method, the name string is "Akhil". When we change 
         * the value of x to "Akhil1", we are actually changing the value of 
         * the name, because a link to it is passed through the x parameter. 
         * It's the same with y - all three of these variables refer to 
         * the same memory location.
         */
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
}