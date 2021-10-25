using System;

public class Town
{
    string name { get, private set}
    int postalCode { get, private set}

    public Town(string name, int postalCode)
    {
        this.name = name;
        this.postalCode = postalCode;
    }
}
