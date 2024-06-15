namespace Task5
{
    internal class StudentView
    {
        public void printStudentDetails(string studentName, string studentRollNo)
        {
            Console.WriteLine("Student: ");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Roll No: {studentRollNo}");
        }
    }
}
