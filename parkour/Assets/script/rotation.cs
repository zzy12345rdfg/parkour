using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    int speed = 100; 

    void Update()
    {
        this.transform.Rotate(Vector3.up * speed*Time.deltaTime);
    }
}
