class Game
{
    private Room _gameRoom;
    private string _commands;
    private Sam _sam;
    private Enemies _enemies;
    private int _nicoRow;
    private int _nicoCol;

    public Game(Room GameRoom, Sam sam, string Commands, int NicoRow, int NicoCol)
    {
        _gameRoom = GameRoom;
        _sam = sam;
        _commands = Commands;
        _nicoRow = NicoRow;
        _nicoCol = NicoCol;
        _enemies = new Enemies();
    }

    private bool IsNicoDead() => _sam.SamRow == _nicoRow;

    public void Play()
    {
        foreach (char command in _commands)
        {
            _sam.CurrentDirection = command;
            _enemies.Move(_gameRoom);
            _sam.Move(_gameRoom);

            if (_sam.IsDead(_gameRoom))
            {
                Console.WriteLine($"\nSam died at {_sam.SamRow}, {_sam.SamCol}");
                _gameRoom.PrintRoom();
                break;
            }
            else if (IsNicoDead())
            {
                _gameRoom.Matrix[_nicoRow][_nicoCol] = 'X';
                Console.WriteLine("\nNikoladze killed!");
                _gameRoom.PrintRoom();
                break;
            }
        }
    }
}