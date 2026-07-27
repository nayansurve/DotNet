using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


 List<Student> students=new List<Student>();
 students.Add(new Student {Id=101,Name="Naina",Age=23,Course="IT"});
 students.Add(new Student{Id=102,Name="Sarthak",Age=24,Course="IT"});
 students.Add(new Student {Id=103,Name="Shivani",Age=22,Course="LLB"});
 students.Add(new Student{Id=104,Name="Samarth",Age=26,Course="Army"});
 students.Add(new Student{Id=0,Name="",Age=0,Course=""});
// get student
app.MapGet("/api/students", () =>
{
    return students;

});

// get student by id
app.MapGet("api/students/{Id}", (int Id) =>
{
      var student=students.FirstOrDefault(s=> s.Id == Id);
      return student;
});
app.MapGet("/api/search/Name/{Name}",(string Name) =>
{
        var student=students.FirstOrDefault(s => s.Name == Name);
        return student;
});

app.MapGet("/api/search/Course/{Course}",(string Course) =>
{ 
    var student=students.FirstOrDefault(s => s.Course == Course);
    return student;
});

// here we get the student by age where the student age is greater than 20
app.MapGet("/api/age/{Age}",(int age) =>
{
    var result=students.Where(s => s.Age > age).ToList();
    return Results.Ok(result);
});

// here by giving this api we count the how many students are there 
app.MapGet("/api/student/count", ()=>
{
    int TotalStudents=students.Count;
    return Results.Ok($"Total Students = {TotalStudents}");
});

app.MapGet("api/AgeCount/{Age}", (int Age) =>
{
    int TotalStudent=students.Count(s => s.Age < Age);
    return Results.Ok($"Total student age whose age is less than {Age}={TotalStudent}");

    
});

// add student
app.MapPost("api/student",(Student student)=>
{
    students.Add(student);
    return Results.Ok(student);
    
});

//update student
app.MapPut("/api/students/{id}",(int id, Student updatedStudent) =>
{

    var student=students.FirstOrDefault(s => s.Id==id);

    if(student == null)
        return Results.NotFound();

        student.Id=updatedStudent.Id;
        student.Name=updatedStudent.Name;
        student.Age=updatedStudent.Age;
        student.Course=updatedStudent.Course;

        return Results.Ok(student);
    
});

//update student by namespace Name
app.MapPut("/api/students/StudentByName/{Name}", (string Name, Student updateStudentByName) =>
{
    var student = students.FirstOrDefault(s => s.Name == Name);

    if (student == null)
        return Results.NotFound();

    student.Id = updateStudentByName.Id;
    student.Name = updateStudentByName.Name;
    student.Age = updateStudentByName.Age;
    student.Course = updateStudentByName.Course;

    return Results.Ok(student);
});

//delete student

app.MapDelete("api/students/{Id}",(int id) =>
{

    var student=students.FirstOrDefault(s => s.Id == id);

    if(student == null)
    return Results.NotFound();

    students.Remove(student);


    return Results.Ok("Student Deleted");

    
});

app.Run();
