// Struct: value type
// Class:  reference type

// Anything that is struct will have default value.

// String -> Immutable
// 

using MyConsoleApp;
using System.Text;
int variableName = Convert.ToInt32(70.9);
// Increment ++
// Decrement --

// char vs = 's';

// Making HTML
StringBuilder table = new StringBuilder();

table.Append($"<table>"); // String Interpolation
for (int i = 0; i <= 11; i++)
{
    table.Append("<tr>");
    table.Append("<td>");
    table.Append($"{i}");
    //table = table + i + " Khan";
    //table = table + string.Format("{i}", i);
    table.Append("</td>");
    table.Append("</tr>");
}
table.Append("</table>");

string myfinalTable = table.ToString();
// Extention method

myfinalTable.Contains("abdullah");

for (int i = 0; i < myfinalTable.Length; i++)
{
    Console.WriteLine(myfinalTable[i]);
}

string id_card_number = "36302-3206735-9";
//string new_string = id_card_number.Replace('-', ',');

var array = id_card_number.Split('-');
var finalcommaString = String.Join(',', array);

// LINQ -> Language Integrated Query
List<int> numbers = new List<int>() { 23 };

numbers.Add(2);
numbers.Add(9);
numbers.Add(23);
numbers.Add(10);
#region
//for (int i = 0; i < numbers.Count; i++)
//{
//    // bool isResultTrue = (numbers[i] == 9);
//    // bool isResultTrue = true;

//    if (numbers[i] == 9) // false
//    {
//        Console.WriteLine("Shahid");
//    }
//}
//foreach (int variable_Name in numbers)
//{
//    if(variable_Name == 9)
//    {
//        Console.WriteLine("condition met.");
//    }
//}
#endregion

int foundNumber = numbers.Find(variable_Name => variable_Name == 9);
bool IsNumberExists = numbers.Contains(9);

int firstNumber = numbers.First();
int firstOrDefaultNumber = numbers.FirstOrDefault();

//int single = numbers.Single(x => x == 20);
//int singleOrDefault = numbers.SingleOrDefault();

int last = numbers.Last();
int lastOrDefault = numbers.LastOrDefault();
int indexValue = numbers.FindIndex(x => x == 9);
// numbers.RemoveAt(indexValue);
// numbers.Remove(9);
bool isNumberExist = numbers.Any(x => x == 9);
bool isConditionMetForAll = numbers.All(x => x > 2);

int maximumNumber = numbers.Max();
int minimumNumber = numbers.Min();
//
var filteredList = numbers.Where(x => x > 5 || x < 10);
var filteredList2 = numbers.Where(x => x > 5 && x < 10);
//numbers.Sort();
var ordered = numbers.OrderBy(x => x);
var desendingOrder = numbers.OrderByDescending(x => x);

// 1,2,3,4,5 ..... 100

var skippedItems = numbers.Skip(2);
var takenItems = numbers.Take(2);
// numbers.Skip(20).Take(10);

var groupValues = numbers.GroupBy(x => x);

List<Person> persons = new List<Person>();

#region
Person p1 = new Person()
{
    FirstName = "Adnan",
    LastName = "Chugtai",
    Age = 26,
    DateOfAdmission = DateTime.Now.AddDays(-10)
};

Person p2 = new Person();
p2.FirstName = "Shahid";
p2.LastName = "Khan";
p2.Age = 25;
p2.DateOfAdmission = DateTime.Now.AddDays(-7);

Person p3 = new Person();
p3.FirstName = "Usman";
p3.LastName = "Ihsan";
p3.Age = 22;
p3.DateOfAdmission = DateTime.Now.AddDays(-11);


Person p4 = new Person();
p4.FirstName = "Shahrukh";
p4.LastName = "Khan";
p4.Age = 25;
p4.DateOfAdmission = DateTime.Now.AddDays(-5);


persons.Add(p1);
persons.Add(p2);
persons.Add(p3);
persons.Add(p4);

#endregion
// var groupedPersonsByAge = persons.GroupBy(x => x.Age);

// Projection + Transformation
var lsst = persons.Select(
    person =>
    new Student()
    {
        Age = person.Age,
        FullName = person.FirstName + " " + person.LastName,
        DateOfAdmission = person.DateOfAdmission.ToString("MM-dd-yyyy H:mm")
    });
// Anonymous Object
//var lsst2 = persons.Select(
//    person => 
//    new 
//    {
//        Name = person.Name,
//        Age = person.Age 
//    });

var names = new List<string> { "Alice", "Bob", "Charlie", "Anna", "Brian" };
var groupedNames = names.GroupBy(n => n[0]).ToList();


double mydouble = 5.5;