class Room
{
    public char[][] Matrix { get; set; }
    public int rowsNum;
    public int colsNum;

    public Room(char[][] Matrix)
    {
        this.Matrix = Matrix;
        rowsNum = this.Matrix.Length;
        colsNum = this.Matrix[0].Length;
    }

    public void PrintRoom()
    {
        foreach (char[] row in Matrix)
        {
            Console.WriteLine(string.Join("", row));
        }
    }
}