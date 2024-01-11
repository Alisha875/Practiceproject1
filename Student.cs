
// Student.cs in SchoolDataLibrary project
public class Student
{
    public string FirstName { get; }
    public string LastName { get; }

    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public bool IsValidFullName()
    {
        // Assuming a valid full name contains both a non-empty first name and last name
        return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
    }
}
