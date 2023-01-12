using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpinner : MonoBehaviour
{
    private Vector3 rotation;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        rotation = new Vector3(0, 0, speed*Time.deltaTime); 
        transform.Rotate(rotation);
    }
}
