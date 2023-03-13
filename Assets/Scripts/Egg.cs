using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum rarity
{
    COMMON, UNCOMMON, RARE, LEGENDARY
}

public class Egg
{
    public rarity r { get; private set; }

    public Egg (rarity r)
    {
        this.r = r;
    }
}
