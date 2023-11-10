using System;

public class Person{

public string name { get; set; }
public double age { get; set; }
public Person(string n, double a){


name = n;
age =a;


}

public double Age{
    get{ return age;} // 'get' is used to retrieve the values of name and age instead of getter functions

}


    public override string ToString() // override keyword is used to override the default ToString
    {
        return name + ", age: " + age;
    }

    public double GetYoungest()
    {
        return age/ 2 +7;
    }

public double GetOldest(){

    return (age - 7)*2;
}


}