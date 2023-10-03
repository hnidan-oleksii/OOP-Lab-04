// Sneaking 

int rowsNum = int.Parse(Console.ReadLine());
char[][] currRoom = new char[rowsNum][];
int samRow = 0; 
int samCol = 0;
int nicRow = 0;
int nicCol = 0;

for (int i = 0; i < rowsNum; i++)
{
    string input = Console.ReadLine();
    currRoom[i] = new char[input.Length];

    for (int j = 0; j < input.Length; j++)
    {
        if (input[j] == 'S')
        {
            samRow = i;
            samCol = j;
        }

        if (input[j] == 'N')
        {
            nicRow = i;
            nicCol = j;
        }

        currRoom[i][j] = input[j];
    }
}

string commands = Console.ReadLine();

Room room = new Room(currRoom);
Sam sam = new Sam(samRow, samCol);
Game game = new Game(room, sam, commands, nicRow, nicCol);
game.Play();

