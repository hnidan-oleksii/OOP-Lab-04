class Sam : IMovable
{
    public char CurrentDirection { get; set; }
    public int SamRow { get; set; }
    public int SamCol { get; set; }

    public Sam(int SamRow, int SamCol)
    {
        this.SamRow = SamRow;
        this.SamCol = SamCol;
    }

    public void Move(Room room)
    {
        room.Matrix[SamRow][SamCol] = '.';

        switch (CurrentDirection)
        {
            case 'U':
                TryKilling(room, true);
                SamRow--;
                break;
            case 'D':
                TryKilling(room, false);
                SamRow++;
                break;
            case 'L':
                SamCol--;
                break;
            case 'R':
                SamCol++;
                break;
            case 'W':
                break;
        }

        room.Matrix[SamRow][SamCol] = IsDead(room) ? 'X' : 'S';
    }

    public bool IsDead(Room room) => room.Matrix[SamRow][0..SamCol].Contains('b') || room.Matrix[SamRow][SamCol..^0].Contains('d');

    private void TryKilling(Room room, bool Up)
    {
        int killingAttemptRow = Up ? SamRow - 1 : SamRow + 1;
        if (room.Matrix[killingAttemptRow][SamCol] == 'b' || room.Matrix[killingAttemptRow][SamCol] == 'd')
        {
            room.Matrix[killingAttemptRow][SamCol] = '.';
        }
    }
}