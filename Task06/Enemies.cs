class Enemies : IMovable
{
    public void Move(Room room)
    {
        for (int row = 0; row < room.rowsNum; row++)
        {
            bool lineEnemyMoved = false;
            for (int col = 0; col < room.colsNum; col++)
            {
                if (!room.Matrix[row].Contains('d') && !room.Matrix[row].Contains('b'))
                {
                    break;
                }

                if (room.Matrix[row][col] == 'b')
                {

                    room.Matrix[row][col] = '.';
                    room.Matrix[row][col + 1] = 'b';
                    lineEnemyMoved = true;

                    if (col + 1 == room.colsNum - 1)
                    {
                        room.Matrix[row][col + 1] = 'd';
                    }
                    break;
                }
                else if (room.Matrix[row][col] == 'd')
                {

                    room.Matrix[row][col] = '.';
                    room.Matrix[row][col - 1] = 'd';
                    lineEnemyMoved = true;

                    if (col - 1 == 0)
                    {
                        room.Matrix[row][col - 1] = 'b';
                    }
                    break;
                }
            }

            if (lineEnemyMoved) continue;
        };
    }
}