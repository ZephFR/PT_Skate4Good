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
        Street,
        Cruiser,
        Longboard,
    }
    public enum BoardChoices
    {
        Popscicle,
        OldSchool,
        Longboard,
        VeryLongboard,
    }
    public enum GripChoices
    {
        Stars,
        Clean,
        MiddleStrip,
    }
         
    public RequestData.WheelsChoices Wheels;
    public RequestData.BoardChoices Board;
    public RequestData.GripChoices Grip;

    public RequestData()
    {
        name = "New Name";
    }

    public RequestData(string name)
    { 
        this.name = name; 
    }

    public RequestData(string name, string order, WheelsChoices Wheels, BoardChoices Board, GripChoices Grip) : this(name)
    {
        this.order = order;
        this.Wheels = Wheels;
        this.Board = Board;
        this.Grip = Grip;
    }
}
