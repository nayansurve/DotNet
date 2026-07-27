using System;
namespace BinarySerilizationDemo;

[Serializable] // it tells that this class is allowed to be converted into a file

public class Employee
{
    public int Id;
    public string Name;
}