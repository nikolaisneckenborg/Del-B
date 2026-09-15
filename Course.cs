class Course(string name, int maxSeats)
{
    public List<Student> students = [];
    public string Name = name;
    public int MaxSeats = maxSeats;

    public void Enroll(Student student)
    {
        if (students.Contains(student))
        {
            Console.WriteLine("Studenten är redan anmäld till kursen!");
        }
        else if(students.Count == MaxSeats)
        {
            Console.WriteLine("Kursen är full");
        }
        else
        {
            students.Add(student);
        }
    }
}