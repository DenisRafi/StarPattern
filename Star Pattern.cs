using System;

public class ByDenisRafi
{
    public static void Main()
    {
        Console.Title = "C# Star Pattern";

        int n = 8;
        for (int i = 0; i < n; ++i)
        {
            stars(i + 1);
            spaces(n - i - 1);
            stars(n - i + 1);
            spaces(2 * i);
            stars(n - i);
            spaces(n - i - 1);
            stars(i + 1);
            Console.WriteLine();
        }
        Console.ReadKey();
    }

    static void stars(int count)
    {
        for (int i = 0; i < count; ++i)
            Console.Write("*");
    }

    static void spaces(int count)
    {
        for (int i = 0; i < count; ++i)
            Console.Write(" ");
    }
}