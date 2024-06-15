using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class StudentController
    {
        private Student model;
        private StudentView view;

        public StudentController(Student model, StudentView view)
        {
            this.model = model;
            this.view = view;
        }

        public void SetStudentName(string name)
        {
            model.SetName(name);
        }

        public string GetStudentName()
        {
            return model.GetName();
        }

        public void SetStudentRollNo(string rollNo)
        {
            model.SetRollNo(rollNo);
        }

        public string getStudentRollNo()
        {
            return model.GetRollNo();
        }

        public void UpdateView()
        {
            view.printStudentDetails(model.GetName(), model.GetRollNo());
        }
    }
}

