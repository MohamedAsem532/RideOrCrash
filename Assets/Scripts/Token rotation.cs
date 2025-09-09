using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Rotate_Coin : MonoBehaviour
{
    float speed=5;
    void Start()
    {
        
    }
    void Update()
    {
        this.transform.Rotate(new Vector3(0,0,30)*speed*Time.deltaTime);
    }
 
}
