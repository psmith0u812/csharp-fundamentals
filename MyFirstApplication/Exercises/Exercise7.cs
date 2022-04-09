
namespace MyFirstApplication;
/*
 Objective 1: Change the type from class to struct. Change the name of the struct
from Exercise7 to Employee. The file name should not be hanged. Created 2 struct variables. 
The first one will be of type int and be named _id. the second variables should be of 
type string and be named _name. Created a constructor that takes 2 arguments, with the
first being an int, and the second a string. The struct variables should be assigned to 
the constructor parameters. Create properties for these 2 variables. 
 */
internal struct Employee
{
    private int _id;
    private string _name;

    public int EmployeeId
    {
        get { return _id; }
        set { _id = value; }
    }

    public string EmployeeName
    {
        get { return _name; }
        set { _name = value; }
    }


    public Employee(int employeeId, string employeeName)
    {
        _id = employeeId;
        _name = employeeName;
    }



} // End struct
// End Objective1

/*
 Objective 2: Create a Record based on your Boat object from Object Oriented 
Programming lesson. In your record body, include the boat method that you 
defined. This record can be in the same file as Exercise1. just put the code 
under it as seen in the lecture. Test your record to ensure it is working correctly. 
 */
internal record Boat(string Deck, string Hull, string Helm)
    
{
    public string ShowBoat()
    {
        return ($"{Deck}, {Hull}, {Helm}");
    }


}// End Objective2


/* Program.cs Testing for Objective 2
 * 
Boat();

void Boat()
{
    Boat myBoat = new Boat("wood", "fiberglass", "mechanical");
    myBoat.ShowBoat();
    Console.WriteLine(myBoat);
    Console.WriteLine($"This boat is {myBoat.Deck} deck, {myBoat.Hull} craft with a {myBoat.Helm} helm");
}
*/