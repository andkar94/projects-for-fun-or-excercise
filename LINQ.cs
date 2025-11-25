int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

var evenNumbers = numbers.Where(n => n % 2 == 0);
var multipledby7 = numbers.Select(n => n * 7);

Console.WriteLine(string.Join(", ", evenNumbers));
Console.WriteLine(string.Join(", ", multipledby7));
