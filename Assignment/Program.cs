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
        {
            int[] copyArray = new int[original.Length];
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
            string response = " ";
            Console.WriteLine(text);
            response = Console.ReadLine();
            int resultnumber = Int32.Parse(response);

            // throw new NotImplementedException();
            return resultnumber;
        }

        /// <summary>
        /// Asks the user for a number within a certain range [min, max]. If the number is not in the range, re-prompt the user for a new number.
        /// Will crash if the user input is not convertible to an int (throw exception?)
        /// </summary>
        /// <param name="text">Text to prompt the user</param>
        /// <param name="min">Smallest permissible value</param>
        /// <param name="max">Largest permissible value</param>
        /// <returns>The user input as an integer</returns>
        public static int AskForNumberInRange(string text, int min, int max)
        {
            string textRange = string.Format("{0} [{1}, {2}]", text, min, max);
            int rangeNum = ArrayReplicator.AskForNumber(textRange);
            // throw new NotImplementedException();
            if (rangeNum >= min && rangeNum <= max)
            {
                return rangeNum;
            }
            else
            {
                return 0;
            }
        }
    }

    static class Program
    {
        static void Main()

        {

            System.Console.WriteLine("Hello World!!");
            const int Min = 0;
            const int Max = 10;
            const int PrintOffset = 4;

            int numInRange = ArrayReplicator.AskForNumberInRange("Enter the number in range: ", Min, Max);
            Console.WriteLine(numInRange);
            Console.WriteLine("Enter an array size in range [0-5]");
            int size = 0;
            while (true)
            {
                size = Int32.Parse(Console.ReadLine());
                if (size > -1 && size < 6)
                {
                    break;
                }
                Console.WriteLine(size + " is not in the specified range. Try again.");
            }
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

            int myVar = ArrayReplicator.AskForNumber("enter a number: ");
            Console.WriteLine(myVar);

        }
    }
}
