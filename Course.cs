class Course(string name, int maxSeats)
{
    public List<Student> students = [];
    public string Name = name;
    public int MaxSeats = maxSeats;

    public void Enroll(Student student)
    {
        if (students.Contains(student))
        {
            Console.WriteLine($"{student.Name} är redan anmäld till {Name}!");
        }
        else if(students.Count == MaxSeats)
        {
            Console.WriteLine($"{Name} är full");
        }
        else
        {
            students.Add(student);
            student.courses.Add(this);
        }
    }
    public void Remove(Student student)
    {
        if (!students.Contains(student))
        {
            Console.WriteLine($"{student.Name} är inte anmäld till {Name}!");
        }
        else
        {
            students.Remove(student);
            student.courses.Add(this);
        }
    }
    public void RollCall()
    {
        if (students.Count < 1)
        {
            Console.WriteLine($"Inga studenter är anmälda tiil {Name}!");
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