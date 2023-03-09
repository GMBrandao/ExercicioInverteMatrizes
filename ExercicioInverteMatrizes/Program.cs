int[,] first = new int[4, 4];
int[,] reverse = new int[4, 4];

int row, col;

for(row = 0; row < 4; row++)
{
    for(col = 0; col < 4; col++)
    {
        first[row, col] = RandomNumber();
    }
}

for (row = 0; row < 4; row++)
{
    for (col = 0; col < 4; col++)
    {
        reverse [3 - row, 3 - col]= first[row, col];
    }
}

PrintMatriz(first);
PrintMatriz(reverse);

void PrintMatriz(int[,] matriz)
{
    Console.WriteLine();
    for (row = 0; row < 4; row++)
    {
        for (col = 0; col < 4; col++)
        {
            Console.Write($"{matriz[row, col], 3} |");
        }
        Console.WriteLine();
    }
}

int RandomNumber()
{
    Random random = new Random();
    int rnd = random.Next(100);
    return rnd;
}