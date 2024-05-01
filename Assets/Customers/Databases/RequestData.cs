using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]

public class RequestData
{
    public string name;
    public string order;
    public enum WheelsChoices
    {
        Moyenne,
        Dures,
        Adhérentes,
        None,
    }
    public enum BoardChoices
    {
        Standard,
        Penny,
        Longboard,
        None,
    }
         
    public RequestData.WheelsChoices Wheels;
    public RequestData.BoardChoices Board;

    public RequestData()
    {
        name = "New Name";
    }

    public RequestData(string name)
    { 
        this.name = name; 
    }

    public RequestData(string name, string order, WheelsChoices Wheels, BoardChoices Board) : this(name)
    {
        this.order = order;
        this.Wheels = Wheels;
        this.Board = Board;
    }
}
