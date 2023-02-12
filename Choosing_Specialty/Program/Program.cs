internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInt()
        {
            Console.WriteLine("Из скольки слов будет состоять ваш массив?");
            Console.WriteLine("Введите число: ");

            if (int.TryParse(Console.ReadLine(), out int i))
            {
                return i;
            }

            Console.WriteLine("Это не число: ");

            return -1;
        }

        string[] GetArray(int length)
        {
            string[] array = new string[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ReadString();
            }
            return array;
        }

        void GetArrayTreeWords(string[] array)
        {
            int index = 0;
            string[] arrayTwo = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length <= 3)
                {
                    arrayTwo[index] = array[i];
                    index++;
                }
            }
            Console.WriteLine("Вы ввели следующие слова состоящие из трех или меньше трех символов:");
            GetPrintArray(arrayTwo);
        }

        string ReadString()
        {
            Console.WriteLine("Введите слова: ");
            string? text = Console.ReadLine();
            return text;
        }

        void GetPrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        string[] arrayOne = GetArray(ReadInt());
        GetArrayTreeWords(arrayOne);
    }
}