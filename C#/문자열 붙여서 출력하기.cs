using System;

public class Example
{
    public static void Main()
    {
        String[] input;

        Console.Clear();
        input = Console.ReadLine().Split(' ');

        String s1 = input[0];
        String s2 = input[1];
        string new_string = s1 + s2;
        Console.WriteLine(new_string);

    }
}