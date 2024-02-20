// See https://aka.ms/new-console-template for more information
using Business.Concerets;
using DataAccess.Conceretes;
using Entities.Conceretes;

Category category = new Category();
category.CategoryName = "Programlama";
category.CategoryId = 1;

Course course = new Course();
course.CourseId = 1;
course.InstructorName = "Engin Demiroğ";
course.CourseDescription = "Bu bir yazılım geliştirici yetiştirme kursudur.";
course.YearOfOpening = 2024;
course.CoursePrice = 0;

Instructor instructor = new Instructor();
instructor.InstructorId = 1;
instructor.InstructorBio = "Yazılım geliştirmeye lisede \"yazılım\" bölümünde okurken başladım.\r\n\r\nÜniversite hayatıma ÖSS 2003 Türkiye derecesiyle başladım...";
instructor.FirstName = "Engin";
instructor.LastName = "Demiroğ";

Console.WriteLine("-------------------* Category Processes *-----------------");
CategoryManager categoryManager = new CategoryManager(new CategoryDal());
categoryManager.Add(category);
categoryManager.Update(category);
categoryManager.Delete(category);

Console.WriteLine("-------------------* Course Processes *-----------------");
CourseManager courseManager = new CourseManager(new CourseDal());
courseManager.Add(course);
courseManager.Update(course);
courseManager.Delete(course);

Console.WriteLine("-------------------* Instructor Processes *-----------------");
InstructorManager instructorManager = new InstructorManager(new InstructorDal());
instructorManager.Add(instructor);
instructorManager.Update(instructor);
instructorManager.Delete(instructor);

