// Hospital

List<Doctor> doctors = new List<Doctor>();
List<Department> departments = new List<Department>();

string input = Console.ReadLine();

while (input != "Output")
{
    string[] values = input.Split();

    string depName = values[0];
    string docName = string.Join(values[1], " ", values[2]);
    string name = values[3];

    Department? department = departments.FirstOrDefault(department => department.Name == depName);
    if (department == null)
    {
        department = new Department(depName);
        departments.Add(department);
    }

    Doctor? doctor = doctors.FirstOrDefault(doctor => doctor.Name == docName);
    if (doctor == null)
    {
        doctor = new Doctor(docName);
        doctors.Add(doctor);
    }

    Patient patient = new Patient(department, doctor, name);

    input = Console.ReadLine();
}


string command = Console.ReadLine();

while (command != "End")
{
    string[] request = command.Split();

    if (request.Length == 1)
    {
        Department dep = departments.First(dep => dep.Name == request[0]);
        PrintAppropriatePatientNames(dep.Rooms);
    }
    else if (int.TryParse(request[1], out _))
    {
        Department dep = departments.First(dep => dep.Name == request[0]);
        Room[] room = { dep.GetRoomById(int.Parse(request[1])) };
        PrintAppropriatePatientNames(room, sortByName: true);
    }
    else
    {
        string doctorName = string.Join(request[0], " ", request[1]);
        List<Room> rooms = new List<Room>();
        foreach (Department dep in departments) foreach (Room room in dep.Rooms) rooms.Add(room);
        PrintAppropriatePatientNames(rooms.ToArray(), sortByName: true, docName: doctorName);
    }

    command = Console.ReadLine();
}



void PrintAppropriatePatientNames(Room[] rooms, bool sortByName = false, string docName = "")
{
    List<string> names = new List<string>();
    foreach (Room room in rooms)
    {
        foreach (Patient patient in room.GetAllPatients())
        {
            if (patient == null) continue;
            if (docName != "") if (patient.DocName != docName) continue;
            names.Add(patient.Name);
        }
    }

    if (sortByName) names.Sort();

    foreach (string name in names) Console.WriteLine(name);
}
