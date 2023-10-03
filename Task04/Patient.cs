class Patient
{
    private Department _department;
    private Doctor _doctor;
    private string _name; 

    public Patient(Department Department, Doctor Doctor, string Name)
    {
        this._department = Department;
        this._name = Name;
        this._department.PutInFirstNotFullRoom(this);
        this._doctor = Doctor;
    }

    public string Name { get => _name; }
    public string DocName { get => _doctor.Name; }

    public override string ToString()
    {
        return $"{_name}";
    }
}