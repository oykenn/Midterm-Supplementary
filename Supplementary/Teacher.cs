public class Teacher : Person, ICourse
{
    public int TeacherID { get; }
    public string Subject { get; }

    public Teacher(string name, int age, Address address, int teacherID, string subject) 
        : base(name, age, address)
    {
        TeacherID = teacherID;
        Subject = subject;
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Teacher Name: {Name}, Age: {Age}, Address: {Address}, Subject: {Subject}");
    }

    public override void Greet()
    {
        Console.WriteLine($"Hello, I am Teacher. {Name}, your {Subject} teacher.");
    }

    public void ShowCourseDetails()
    {
        Console.WriteLine($"Teacher ID: {TeacherID} I'm Teaching {Subject}");
    }
}
