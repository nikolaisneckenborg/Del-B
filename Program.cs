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

courses[0].RollCall();

Console.WriteLine(courses[0].ToString());
courses[0].Enroll(students[0]); // Första ska gå bra
Console.WriteLine(courses[0].ToString());
courses[0].Enroll(students[0]); // nästa ska ge felmeddelande
courses[0].Enroll(students[1]); // Lägga till en andra student ska gå bra
Console.WriteLine(courses[0].ToString());
courses[0].Enroll(students[2]); // Nu ska kursen ge felmeddelanda att den är full
Console.WriteLine(courses[0].ToString());

courses[0].RollCall(); // Kalle + Pelle
courses[0].Remove(students[1]);
courses[0].RollCall(); // Bara Kalle

students[0].Schedule(); // Kalle är inte anmäld
students[0].Join(courses[2]); 
students[0].Schedule(); // Chemistry