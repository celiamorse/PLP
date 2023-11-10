
//With help from "https://www.w3schools.com/cs/cs_inheritance.php"
using System;






class CreepyDating
{

    static void Main()
    {
    // create a Person object

    PersonFactory pfClient = new PersonFactory();
    Person client = pfClient.makePerson();
    Console.WriteLine(client);


    List<Person> dates = new List<Person>{

        new Person("Sean", 25),
        new Person("Evan", 30),
        new Person("Bob", 28),
    };

    foreach (Person item in dates)
    Console.WriteLine(item);

    foreach(Person date in dates){

        if(client.GetOldest()>date.Age && client.GetYoungest() < date.Age)
        Console.WriteLine(client.name + " can date " + date.name);




    }

    Console.WriteLine("Thats all your dates!");

   



    













    }
}
