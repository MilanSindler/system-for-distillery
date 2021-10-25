using System;
using Town;

public class Person
{
    int birthNum { get, private set}
    string name { get, private set}
    string surname { get, private set}
    Town town { get, private set}
    string street { get, private set}
    int descriptiveNumber { get, private set}

    public Person(int birthNum, string name, string surname, Town town, string street, int descriptionNumber)
    {
        this.birthNum = birthNum;
        this.name = name;
        this.surname = surname;
        this.town = town;
        this.street = street;
        this.descriptiveNumber = descriptiveNumber;
    }

    public override string ToString()
    {
        return string.Format("{0} {1}[{2}] [{3}({4}) {5} {6}-{7}]", name, surname, birthNum, town.name, town.postalCode, street, descriptiveNumber);
    }

}
