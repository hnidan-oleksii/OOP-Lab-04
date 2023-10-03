using System.Text;

class Department
{
    private Room[] _rooms = new Room[20];
    public Department(string Name)
    {
        this.Name = Name;
        for (int i = 0; i < 20; i++) _rooms[i] = new Room(i); 
    }
    public string Name { get; }
    public Room[] Rooms { get => _rooms; }

    public Room GetRoomById(int id) => _rooms.First(room => room.Id == id - 1);
    public void PutInFirstNotFullRoom(Patient patient) => _rooms.First(room => room.IsFull == false).PutPatient(patient);
}