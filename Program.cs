Student[] students = [new ("Kalle"), new ("Pelle"), new ("Olle")];
Course[] courses = [new ("Math", 2), new ("Biology", 40), new ("Chemistry", 28)];

/*
foreach(Student student in students)
{
    Console.WriteLine(student.Name);
}
*/

/*
foreach(Course course in courses)
{
    Console.WriteLine($"Course: {course.Name} - Seats: {course.MaxSeats}");
}
*/

courses[0].RollCall();  // inga anmälda

Console.WriteLine(courses[0].ToString());  // Math 0/2

courses[0].Enroll(students[0]); // Lägg till Kalle till Math
Console.WriteLine(courses[0].ToString()); // Math 1/2

courses[0].Enroll(students[0]); // nästa ska ge felmeddelande
courses[0].Enroll(students[1]); // Lägg till Pelle till Math
Console.WriteLine(courses[0].ToString()); // Math 2/2

courses[0].Enroll(students[2]); // Nu ska kursen ge felmeddelanda att den är full
Console.WriteLine(courses[0].ToString()); // Math 2/2

courses[0].RollCall(); // Kalle + Pelle
courses[0].Remove(students[1]); // Ta bort Pelle
courses[0].RollCall(); // Bara Kalle

students[0].Schedule(); // Kalle är med i Math

students[0].Join(courses[2]); 
students[0].Schedule(); // Kalle är med I Math + Chemistry

students[0].Leave(courses[1]);  // inte anmäld till kursen Biology
students[0].Leave(courses[2]);  // Kalle lämnar Chemistry
students[0].Schedule(); // Kalle med i bara Math