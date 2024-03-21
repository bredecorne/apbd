// See https://aka.ms/new-console-template for more information
// 3rd change

Console.WriteLine("Hello, World!");
Console.WriteLine(CalculateAverage([1, 4, 6, 8]));
Console.WriteLine(CalculateMax([1, 4, 6, 8]));

static double CalculateAverage(int[] array)
{
    return array.Average();
}

static double CalculateMax(int[] input)
{
    return input.Max();
}