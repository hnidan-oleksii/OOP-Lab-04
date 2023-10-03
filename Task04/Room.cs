class Room
{
    private Patient[] _patients = new Patient[3];
    private int _id;
    private int _freeBeds = 3;
    private bool _isFull = false;
    public Room(int Id)
    {
        _id = Id;
    }
    public int Id { get => _id; }
    public bool IsFull { get => _isFull; }


    public void PutPatient(Patient patient)
    {
        if (_freeBeds == 1) _isFull = true;

        _patients[3 - _freeBeds] = patient;
        _freeBeds--;
    }

    public Patient[] GetAllPatients() => _patients;
}