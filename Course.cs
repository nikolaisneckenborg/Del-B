class Course(string name, int maxSeats)
{
    public List<Student> students = [];
    public string Name = name;
    public int MaxSeats = maxSeats;

    public void Enroll(Student student)
    {
        if (!students.Contains(student))
        {
            students.Add(student);
        }
        else
        {
            Console.WriteLine("Studenten är redan anmäld till kursen!");
        }
    }
}