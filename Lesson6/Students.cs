using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
	class Students
	{
		public string lastName;
		public string firstName;
		public string university;
		public string faculty;
		public int course;
		public string department;
		public int group;
		public string city;
		public int age;
		// Создаем конструктор
		public Students(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
		{
			this.lastName = lastName;
			this.firstName = firstName;
			this.university = university;
			this.faculty = faculty;
			this.department = department;
			this.age = age;
			this.course = course;
			this.group = group;
			this.city = city;
		}

	}
}
