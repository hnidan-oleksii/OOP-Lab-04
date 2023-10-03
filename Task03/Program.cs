// Jedi Galaxy

string[] dimensions = Console.ReadLine().Split();
int rows = int.Parse(dimensions[0]);
int cols = int.Parse(dimensions[1]);

int[,] matrix = new int[rows, cols];
int currNum = 0;
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        matrix[i, j] = currNum;
        currNum++;
    }
}

int ivoScore = 0;
int ivoRow;
int ivoCol;
int evilRow;
int evilCol;

string[] input = Console.ReadLine().Split();
while (input.Length == 2)
{
    ivoRow = int.Parse(input[0]) - 1;
    ivoCol = int.Parse(input[1]) - 1;

    string[] evil = Console.ReadLine().Split();
    evilRow = int.Parse(evil[0]) - 1;
    evilCol = int.Parse(evil[1]) - 1;

    while (evilRow >= 0 && evilCol >= 0)
    {
        matrix[evilRow, evilCol] = 0;
        evilRow--; 
        evilCol--;
    }

    while (ivoRow >= 0 && ivoCol >= 0)
    {
        ivoScore += matrix[ivoRow, ivoCol];
        ivoRow--;
        ivoCol++;
    }

    input = Console.ReadLine().Split();
}

Console.WriteLine(ivoScore);

