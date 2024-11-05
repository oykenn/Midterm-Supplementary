public class Student : Person, ICourse
{
    public int StudentID { get; }

    public Student(string name, int age, Address address, int studentID) 
        : base(name, age, address)
    {
        StudentID = studentID;
    }

    public void Study()
    {
        Console.WriteLine($"{Name} is studying.");
    }

    public void Study(string subject)
    {
        Console.WriteLine($"{Name} is studying {subject}.");
    }

    public override void ShowDetails()
    {
        Console.WriteLine($"Student Name: {Name}, Age: {Age}, Address: {Address}");
    }

    public override void Greet()
    {
        Console.WriteLine($"Hi, I'm {Name}, a student!");
    }

    public void ShowCourseDetails()
    {
        Console.WriteLine($"Student ID: {StudentID} from Bacherlor of Science in Computer Science.");
    }
}
