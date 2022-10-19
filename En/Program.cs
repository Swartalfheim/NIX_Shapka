namespace En
{
    internal class Program
    {
        public static void Print(int[] arr, string t, int size)
        {
            Console.Write(t);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static void Print(string[] arr, string t, int size)
        {
            Console.Write(t);
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static int Rez(string[] mass, string t, int size)
        {
            char[] s = new char[] { 'a', 'e', 'i', 'd', 'h' };
            const int ascii1 = 97, ascii2 = -32;
            int rez = 0;
            for (int i = 0; i < size; i++)
            {
                int ascii = int.Parse(mass[i]) + ascii1 - 1;
                if (Array.IndexOf(s, (char)ascii) > -1)
                {
                    mass[i] = ((char)(ascii + ascii2)).ToString();
                    rez++;
                }
                else
                {
                    mass[i] = ((char)ascii).ToString();
                }
            }
            Print(mass, t, size);
            return rez;
        }

        public static void Main(string[] args)
        {
            Random random = new Random();
            int n1;
            int n2 = 0;
            int n3 = 0;
            int c1, c2;
            int[] mass;
            string[] arr1, arr2;
            bool result;
            Console.WriteLine("Enter array size: (array size can not be less than 1)");
            string inp = Console.ReadLine();
            result = int.TryParse(inp, out n1);

            mass = new int[n1];
            arr1 = new string[n1];
            arr2 = new string[n1];
            for (int i = 0; i < n1; i++)
            {
                mass[i] = random.Next(1, 27);
                if (mass[i] % 2 == 0)
                {
                    arr1[n2] = mass[i].ToString();
                    n2++;
                }
                else
                {
                    arr2[n3] = mass[i].ToString();
                    n3++;
                }
            }
            Print(mass, "mass1:", n1);
            Print(arr1, "mass1:", n2);
            Print(arr2, "mass2:", n3);
            Console.WriteLine();
            c1 = Rez(arr1, "mass1:", n2);
            c2 = Rez(arr2, "mass2:", n3);
            if (c1 > c2)
            {
                Console.WriteLine($"\nmass1 have capital letters ({c1})");
            }
            if (c2 > c1)
            {
                Console.WriteLine($"\nmass2 have capital letters ({c2})");
            }
            else
            {
                Console.WriteLine($"\ntwo arrays have the same number of capital letters");
            }
        }
    }
}