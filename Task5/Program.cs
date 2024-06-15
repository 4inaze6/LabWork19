using Task5;

Student model = retriveStudentFromDatabase();

StudentView view = new StudentView();

StudentController controller = new StudentController(model, view);

controller.UpdateView();

controller.SetStudentName("John");

controller.UpdateView();


static Student retriveStudentFromDatabase()
{
    Student student = new Student();
    student.SetName("Robert");
    student.SetRollNo("10");
    return student;
}