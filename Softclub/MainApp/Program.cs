using Domain.Models;
using Infrastructure;


var employee1=new Employee();
employee1._firstName="Alijon";
employee1._lastName="Sattorov";
employee1._birthDate=new DateTime(2002,04,17);
employee1._salary=20000;

var employee2=new Employee();
employee2._firstName="Anushervon";
employee2._lastName="Ikromov";
employee2._birthDate=new DateTime(2005,06,27);
employee2._salary=8000;


var employee3=new Employee();
employee3._firstName="Farrukh";
employee3._lastName="Saimurodov";
employee3._birthDate=new DateTime(2004,05,01);
employee3._salary=12000;

var employee4=new Employee();
employee4._firstName="Shahzod";
employee4._lastName="Saimurodov";
employee4._birthDate=new DateTime(2002,07,09);
employee4._salary=15000;

var employee_service=new EmployeeService();
employee_service.AddEmployees(employee1);
employee_service.AddEmployees(employee2);
employee_service.AddEmployees(employee3);
employee_service.AddEmployees(employee4);
System.Console.WriteLine();
  System.Console.WriteLine();
    System.Console.WriteLine("<<<<<<<<<<*******>>>>>>>>>>");
foreach (var item in employee_service.GetEmployees())
{
    System.Console.WriteLine();
    System.Console.WriteLine(item._firstName);
    System.Console.WriteLine(item._lastName);
    System.Console.WriteLine(item._birthDate);
    System.Console.WriteLine(item._salary);
    System.Console.WriteLine();
    System.Console.WriteLine("<<<<<<<<<<*******>>>>>>>>>>");
}


var deportament1=new Departament();
deportament1._name="Sattorov Alijon";
deportament1._description="Man donishjui kursi 4-i DMT";

var deportament2=new Departament();
deportament2._name="Ikromov Anushervon";
deportament2._description="Man donishjui kursi 1-i DMT";
var deportament3=new Departament();
deportament3._name="Saimurodov Farrukh";
deportament3._description="Man donishjui kursi 3-i DMT";
var deportament4=new Departament();
deportament4._name="Saimurodov Shahzod";
deportament4._description="Man donishjui kursi 4-i DDZ";


var deportament_service=new DepartamentService();
deportament_service.AddDepartaments(deportament1);
deportament_service.AddDepartaments(deportament2);
deportament_service.AddDepartaments(deportament3);
deportament_service.AddDepartaments(deportament4);

  
  System.Console.WriteLine();
  System.Console.WriteLine();
    System.Console.WriteLine("<<<<<<<<<<*******>>>>>>>>>>");

foreach (var item in deportament_service.GetDepartaments())
{
    System.Console.WriteLine();
    System.Console.WriteLine(item._name);
    System.Console.WriteLine(item._description);
    System.Console.WriteLine();
    System.Console.WriteLine("<<<<<<<<<<*******>>>>>>>>>>");
}