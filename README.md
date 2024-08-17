# README

This library defines a Nuget package that contains extension methods for various .NET
integer types, to quickly determine if they contain values that are even or odd.

A quick reminder; even values are values that are divisible by 2, so -2, 0, 2, 4, 6, and so on,
and odd values are all the other values, so -1, 1, 3, 5, 7, and so on.

## Installation

To install the nuget package into your project, either use your favorite nuget package
manager, or use the following command:

    dotnet add package EvenOrOdd

## Usage

All existing .NET integer data types are given two new extension methods:

    public static bool IsEven(this TYPE value) { ... }
    public static bool IsOdd(this TYPE value) { ... }

You would simply use them as any other extension method. Here is an example:

    int numberOfSmellySocks = File.ReadAllLines("smellysocks.txt").Length;
    if (numberOfSmellySocks.IsEven())
        Console.WriteLine("Even smellyness detected, both your feet smell");
    else
        Console.WriteLine("Uneven smellyness detected, one of your feet is not smelling as much");
