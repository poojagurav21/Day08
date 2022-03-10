// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Student student = new Student();
student.StudentRecord();
student.DisplayAllStudentRecoed();
student.DisplayStudentRecord(1);
public interface IStudent
{
    public void StudentRecord();
    public void UpdateStudent();
    public void DisplayStudentRecord(int i);
    public void DisplayAllStudentRecoed();
    public void FindStudentsMarks();
}

public interface ISubject
{
    public void Subjects();
    public void AllSubject();
    public void UpdateSubject();

    public void AddMarks();
}


class Student : IStudent
{
    StudentRec[] student= new StudentRec[2];
    

    private string _studentName;
    private string _address;
    private string _dateOfBirth;
    private string _gender;
    private string _class;
    public struct StudentRec
    {
        public string Name;
        public string Address;
        public string DateOfBirth;
        public string Gender;
        public string Class;
    }


    public enum Gender
    {
        NotProvided,
        Male,
        Female
    }
    public  void StudentRecord()
    {


       

        for (int i = 0; i < student.Length; i++)
        {
            Gender gender = Gender.NotProvided;
            Console.WriteLine("Enter Student Name: ");
            student[i].Name = Console.ReadLine();
            Console.WriteLine("Enter Student Address: ");
            student[i].Address = Console.ReadLine();
            Console.WriteLine("Enter Student Date of birth: ");
            student[i].DateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter Student Gender: ");
            student[i].Gender = Console.ReadLine();
            var genderText = (Gender)Enum.Parse(typeof(Gender), student[i].Gender);
            Console.WriteLine();
            Console.WriteLine("Enter Student Class: ");
            student[i].Class = Console.ReadLine();
        }

        
    }
    public void DisplayAllStudentRecoed()
    {
        for (int i = 0; i < student.Length; i++)
        {
            Console.WriteLine($"Student Name: {student[i].Name}\nStudent Address: {student[i].Address}\n" +
                $"Student Date Of Birth: {student[i].DateOfBirth}\nStudent Class: {student[i].Class}");
        }
    }

    public void DisplayStudentRecord(int i)
    {
        
            Console.WriteLine($"Student Name: {student[i].Name}\nStudent Address: {student[i].Address}\n" +
                $"Student Date Of Birth: {student[i].DateOfBirth}\nStudent Class: {student[i].Class}");
   
    }

    public void FindStudentsMarks()
    {
        //throw new NotImplementedException();
    }

    

    public void UpdateStudent()
    {
        throw new NotImplementedException();
    }
}
class Subject : ISubject
{
    public void AddMarks()
    {
        throw new NotImplementedException();
    }

    public void AllSubject()
    {
        throw new NotImplementedException();
    }

    public void Subjects()
    {
        throw new NotImplementedException();
    }

    public void UpdateSubject()
    {
        throw new NotImplementedException();
    }
}