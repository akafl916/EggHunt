using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    public int pointValue { get; private set; }
    public string name { get; private set; }


    public Card(int pointValue)
    {
        this.pointValue = pointValue;
    }
}
