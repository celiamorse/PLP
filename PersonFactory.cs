using System;

class PersonFactory{

    public Person makePerson(){
        Console.WriteLine("Client, what is your name? : ");
        string name = Console.ReadLine();
        Console.WriteLine(name + ", enter your age: ");
        if(int.TryParse(Console.ReadLine(), out int age )){ //Parse the user input as an integer
           
            return new Person(name, age);

        }
        else{

            Console.WriteLine("Invalid age input");
            return new Person("Default", 0); // Must return a default person

        }


    }

    
}