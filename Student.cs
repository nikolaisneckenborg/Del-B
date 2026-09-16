using System.Runtime.CompilerServices;

class Student(string name)
{
    public List<Course> courses = [];
    public string Name = name;

    public void Join(Course course)
    {
        if (courses.Contains(course))
        {
            Console.WriteLine("Studenten är redan anmäld till kursen!");
        }
        else if(course.students.Count == course.MaxSeats)
        {
            Console.WriteLine("Kursen är full!");
        }
        else
        {
            courses.Add(course);
        }
    }

    public void Schedule()
    {
         if (courses.Count < 1)
        {
            Console.WriteLine($"{Name} är inte anmäld till några kurser!");
        }
        else
        {
            foreach(Course course in courses)
            {       
                Console.WriteLine(course.Name);
            }
        }
    }

}