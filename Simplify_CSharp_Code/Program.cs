

// 1 using the static
using Microsoft.Data.SqlClient;
using Simplify_CSharp_Code;
using static System.Console;

WriteLine("Hello, World!");


// list initilization method

List<string> list = new List<string>()
{
    "Tim",
    "Sue",
    "Bilbo"
};

List<string> names = ["first , second , third"];


// new instance of list 
List<int> number = new();

// here we know type still using var -- bad 
//var numbers = new List<int> { 1, 2, 3, 4, 5 };

var parameters = new { firstName = "Tim", lastName = "Corey" };
// this is fully functional class withou declaring names its like anonymous type

(string firstName, string lastName) GetFullName()
{
    return ("Tim", "Corey");
}

(string firstName, string lastName) fullName = GetFullName();
WriteLine($"First Name: {fullName.firstName}");
WriteLine($"Last Name: {fullName.lastName}");

// only for the first name
(string firstName, _) = GetFullName();

// only for the last name
(string _, string lastName) = GetFullName();

object emp = new EmployeeRecord(3, "Tim Corey");

if (emp is not null)
{
    WriteLine("Emp is not null");
}

if (emp is EmployeeRecord e && e.Id == 3)
{
    WriteLine($"Employee ID: {e.Id}");
    WriteLine($"Employee Name: {e.Name}");
}
else
{
    WriteLine("Emp is not EmployeeRecord");
}

// IDisposable - Dispose
// uisng works only on class that implement IDisposable interface
using (var conn = new SqlConnection("connection string"))
{
    conn.Open();
}

// using without curly braces
using var connection = new SqlConnection("connection string");
// this using statement will automatically call Dispose on the connection object when it goes out of scope

// data access

string numberText = "43";
int numberValue = 0;

int.TryParse(numberText, out numberValue); 

//insted of this declare direcly in the out

int.TryParse(numberText, out int newNumberValue);