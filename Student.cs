using System.Runtime.CompilerServices;

class Student(string name)
{
    public List<Course> courses = [];
    public string Name = name;

    public void Join(Course course)
    {
        if (courses.Contains(course))
        {
            
        }
        else if(course.students.Count == course.MaxSeats)
        {
            Console.WriteLine($"{Name} är full!");
        }
        else
        {
            courses.Add(course);
            course.students.Add(this);
        }
    }
    public void Leave(Course course)
    {
        if (!courses.Contains(course))
        {
            Console.WriteLine($"{Name} är inte anmäld till {course.Name}!");
        }
        else
        {
            courses.Remove(course);
            course.students.Add(this);
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
    public override string ToString()
    {
        return Name;
    }

}