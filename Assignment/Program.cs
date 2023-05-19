namespace Assignment
{
    public static class ArrayReplicator
    {
        /// <summary>
        /// Replicates (deep copies) the incoming array
        /// </summary>
        /// <param name="original">The array to be replicated</param>
        /// <returns>A deep copy of the original array</returns>
        public static int[] ReplicateArray(int[] original)
        {   //setting replicated array length based on original array length
            int[] copyArray = new int[original.Length];
            // using for loop to set the replicated array index value based on the original array index value
            for (int j = 0; j < original.Length; ++j)
            {
                copyArray[j] = original[j];

            }
            return copyArray;
            // throw new NotImplementedException();
        }

        /// <summary>
        /// Asks the user for a number. Will crash if the user input is not convertible to an int (throw exception?)
        /// </summary>
        /// <param name="text">Text to prompt the user</param>
        /// <returns>The user input as an integer</returns>
        public static int AskForNumber(string text)
        {
            string response = "";
            Console.WriteLine(text);
            /* 
               Checking for condition if the string is empty or not
               While loop forces the user to enter the value as it does not exit until 
               the value is not null or string.
             */
            int resultnumber = 0;
            while (true)
            {
                response = Console.ReadLine();
                /*
                 checking is user input is null, empty or a string. 
                 if any of these conditions meet, prompt user to renter value
                 If not, return the String value as an integer
                */
                if (string.IsNullOrEmpty(response) || response.All(char.IsLetter))
                {
                    Console.WriteLine("Input not valid. Please enter an integer value. ");

                }
                else
                {
                    resultnumber = Int32.Parse(response); // Conversion of the string into int32
                    return resultnumber;
                }
            }
        }

        /// <summary>

        /// Will crash if the user input is not convertible to an int (throw exception?)
        /// </summary>
        /// <param name="text">Text to prompt the user</param>
        /// <param name="min">Smallest permissible value</param>
        /// <param name="max">Largest permissible value</param>
        /// <returns>The user input as an integer</returns>
        public static int AskForNumberInRange(string text, int min, int max)
        {
            string textRange = string.Format("{0} [{1}, {2}]", text, min, max);
            // Using the function AskForNumber to get user input to avoid repeatibility of the code
            int rangeNum = ArrayReplicator.AskForNumber(textRange);
            /*
                re prompting the user if the value is not in the interval range. 
                Here part of task 1 is integrated with task 2.
            */
            while (true)
            {

                if (rangeNum >= min && rangeNum <= max)
                {
                    return rangeNum;
                }
                else if (rangeNum < 0)
                {
                    Console.WriteLine("{0} is not in the specified range. Try again.", rangeNum);
                    rangeNum = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    textRange = string.Format("{0} is not in the specified range. Try again.", rangeNum);
                    rangeNum = ArrayReplicator.AskForNumber(textRange);

                }
            }
        }
    }

    static class Program
    {
        static void Main()

        {

            System.Console.WriteLine("Hello World!!");
            // Constant initialisation
            const int Min = 0;
            const int Max = 5;
            const int PrintOffset = 4;
            // Task 1 call for the method to ask user to imput a number.
            int myVar = ArrayReplicator.AskForNumber("enter a number: ");
            Console.WriteLine(myVar);

            /// Asks the user for a number within a certain range [min, max]. If the number is not in the range, re-prompt the user for a new number.
            int size = ArrayReplicator.AskForNumberInRange("Enter an array size in range: ", Min, Max);
            int[] original = new int[size];

            // Fill the original array with user specified integers
            for (int item = 0; item < size; ++item)
            {
                original[item] = ArrayReplicator.AskForNumber("Enter a number: ");
            }

            int[] copy = ArrayReplicator.ReplicateArray(original);
            // Verify original and replicated array are the same
            for (int index = 0; index < size; ++index)
                Console.WriteLine($"Original {original[index],-PrintOffset}  {copy[index],4} Copy");

        }
    }
}
