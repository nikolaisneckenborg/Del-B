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
            student.Join(this);
        }
    }
    public void Remove(Student student)
    {
        if (!students.Contains(student))
        {
            Console.WriteLine("Studenten är inte anmäld till kursen!");
        }
        else
        {
            students.Remove(student);
            student.Leave(this);
        }
    }
    public void RollCall()
    {
        if (students.Count < 1)
        {
            Console.WriteLine("Inga studenter är anmälda!");
        }
        else
        {
            foreach(Student student in students)
            {       
                Console.WriteLine(student.Name);
            }
        }
        
    }
    public override string ToString()
    {
        return $"{Name} ({students.Count}/{MaxSeats} platser)";
    }
}