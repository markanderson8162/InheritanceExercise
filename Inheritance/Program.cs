using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            string inches = "in";
            Birds toucan = new Birds();

            toucan.Name = "Toucan Sam";
            toucan.Legs = 2;
            toucan.WingSpan = 8.06;
            toucan.WarmBlood = true;
			//string caw = "CAAAAW!";

			Console.WriteLine($"My bird sounds like this: {toucan.BirdSound()}");

			Reptiles gecko = new Reptiles();

            gecko.Name = "Geico";
            gecko.Legs = 4;
            gecko.TailLength = 5.2;
            bool tongue = true;
            string isTongueUsed = "";
            if(gecko.UseTongue(tongue))
			{
                isTongueUsed = "He stuck his tongue out!";
			}
			else
			{
                isTongueUsed = "His mouth is closed.";
			}

            Console.WriteLine($"My bird is named {toucan.Name}. He has {toucan.Legs} legs, his wingspan is {toucan.WingSpan}{inches}, and he is {toucan.WarmBlood}. ");
            Console.WriteLine($"My lizard is named {gecko.Name}. He has {gecko.Legs} legs, and his tail is {gecko.TailLength}{inches}. {gecko.UseTongue(tongue)} ");

        }
    }
}
