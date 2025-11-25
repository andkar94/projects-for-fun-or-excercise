Random random = new Random();
int z = 20;

while (true)
{
    Console.Clear();
    string[,] matrix = new string[z,z];

    for (int i = 0; i < matrix.GetLength(0)/1.5; i++)
    {
        for (int j = 0; j < matrix.GetLength(1)/1.6; j++)
        {
            int k = random.Next(0, z);
            int l = random.Next(0, z);

            matrix[k, l] = "o";                 
        }
    }
 
    for (int i = 0; i < matrix.GetLength(0); i++)
    { 
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            string el = (matrix[i, j]);
            if (el==null)
                el = " ";
            Console.Write(el + " ");           
        }
        Console.WriteLine();
    }
    Console.ReadKey();  
}
