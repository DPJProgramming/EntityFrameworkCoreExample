
using Entity_Framework_core_example;

using StudentContext dbContext = new();

//add with ef core
Student s = new() {
	FullName = "David Poop",
	EmailAddress = "Email@email.com",
	DateOfBirth = new DateTime(2000, 1, 12)
};

dbContext.Students.Add(s);//prepares students insert statement
dbContext.SaveChanges();//executes prepared insert


//retrieve students from database
List<Student> allStudents = dbContext.Students.ToList();

foreach(Student stu in allStudents) {
	Console.WriteLine($"{stu.FullName} has an email of {stu.EmailAddress}");
	Console.WriteLine();
}

