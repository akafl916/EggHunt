using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attributes : MonoBehaviour
{
    public string accountName { get; private set; }
    public int totalPoints { get; private set; }
    public List<Egg> eggs { get; }
    public List<Card> cards { get; }
     



    public static Attributes Instance { get; private set; }
    private void Awake()
    {
        // If there is an instance, and it's not me, delete myself.

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
