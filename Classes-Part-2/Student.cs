using System;
namespace Classes_Part_2
{
	public class Student
	{
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            // Update the appropriate properties: NumberOfCredits, Gpa
            this.NumberOfCredits += courseCredits;

        }

        //TODO: Complete the GetGradeLevel method here:
        public string GetGradeLevel(int credits)
        {
            string gradeLevel = "";
            // Determine the grade level of the student based on NumberOfCredits
            if (29 > credits > 0)
            {
                gradeLevel = "Freshman";
            }
            else if (59 > credits > 30)
            {
                gradeLevel = "Sophmore";
            }
            else if (89 > credits > 60)
            {
                gradeLevel = "Jumior";
            }
            else if (credits > 90)
            {
                gradeLevel = "Senior";
            }
            else 
            {
                gradeLevel = "TBD"
            }

            return gradeLevel;
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
    }
}

