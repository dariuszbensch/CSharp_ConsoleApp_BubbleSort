using System;



namespace ConsoleApp_BubbleSort1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 1, 4, 2, 4, 5, 7, 4, 3, 6, 3, 0, 0 };
            Sorting a = new Sorting();

            foreach (int n in a.fromLowest(tab)) Console.WriteLine(n);
            foreach (int n in a.fromHighest(tab)) Console.WriteLine(n);

            Console.ReadKey();
        }
    }



    class Sorting
    {
        int temporaryValueKeeper = 0;

        public int[] fromLowest(int[] tab)
        {
            for (int i = 0; i < tab.GetLength(0) - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    temporaryValueKeeper = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = temporaryValueKeeper;
                    i = -1;
                }
            }
            return tab;
        }



        public int[] fromHighest(int[] tab)
        {
            for (int i = 0; i < tab.GetLength(0) - 1; i++)
            {
                if (tab[i] < tab[i + 1])
                {
                    temporaryValueKeeper = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = temporaryValueKeeper;
                    i = -1;
                }
            }
            return tab;
        }
    }
}
