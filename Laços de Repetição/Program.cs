internal class Program
{
    private static void Main(string[] args)
    {
        int index1 = 1, index2 = 1;

        while (index1 <= 10)
        {
            Console.WriteLine("Execução While nº " + index1);
            index1++;
        }

        Console.WriteLine("--------------");

        do 
        {
            Console.WriteLine("Execução Do While nº " + index2);
            index2++;
        } 
        while (index2 <= 10);

        Console.WriteLine("--------------");

        for (int i = 10; i < 0; i--)
        {
            Console.WriteLine("Execução For nº " + (i+1));
        }

        Console.WriteLine("--------------");

        int[] arrayDeInteiros = {3, 5, 7, 9};

        foreach (int i in arrayDeInteiros)
        {
            Console.WriteLine("Valor atual: " + i);
        }

    }
}