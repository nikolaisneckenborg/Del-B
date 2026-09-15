Student[] students = [new ("Kalle"), new ("Pelle"), new ("Olle")];
Course[] courses = [new ("Math", 50), new ("Biology", 40), new ("Chemistry", 28)];


foreach(Student student in students)
{
    Console.WriteLine(student.Name);
}

foreach(Course course in courses)
{
    Console.WriteLine($"Course: {course.Name} - Seats: {course.MaxSeats}");
}

courses[0].Enroll(students[0]); // Första ska gå bra
courses[0].Enroll(students[0]); // nästa ska ge felmeddelande