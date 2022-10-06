using System;


namespace NumRangeLibrary
{
   
    public class Class1
    {

        public Class1()
        {
            runProgram();
        }

        public static void runProgram()
        {
            const int exitNumber = -1;

            //display menu.
            DisplayMenu();

            do
            {

                //get input from user.(assume input is from 0 to 100 or -1)
                Console.Write("\n Enter a number: ");
                int inputValue = int.Parse(Console.ReadLine());

                //exits program if exitNumber(-1)
                if (inputValue == exitNumber) return;

                //display category based on user input.
                GetCategory(inputValue);

            } while (true);
        }
        public static void DisplayMenu()
        {
            // display each categories with asscociated ranges
            int min_range = 0;
            foreach (int value in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($" {Enum.GetName(typeof(Category), value)} has the range {min_range} - {value}");
                min_range = value + 1;
            }

        }

        public static void GetCategory(int number)
        {
            // output the category of number

            Console.Write("\n Result:");
            foreach (int category_value in Enum.GetValues(typeof(Category)))
            {
                if (number <= category_value)
                {
                    Console.WriteLine($" Value is in the {Enum.GetName(typeof(Category), category_value)} range.\n");
                    return;
                }
            }
        }
    }
}
