Student[] students = [new ("Kalle"), new ("Pelle"), new ("Olle")];
Course[] courses = [new ("Math", 2), new ("Biology", 40), new ("Chemistry", 28)];


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
courses[0].Enroll(students[1]); // Lägga till en andra student ska gå bra
courses[0].Enroll(students[2]); // Nu ska kursen ge felmeddelanda att den är full