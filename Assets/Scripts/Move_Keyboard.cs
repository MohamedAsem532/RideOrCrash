/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Move_Keyboard : MonoBehaviour
{
  
  
    Vector3 goal;
    float Angle = 90.0f;
    float speed=3.0f;
    private int count;
    public TextMeshProUGUI score; // to show score
    void Start()
    {
         count = 0;// for score function
        
        goal=this.transform.position;

    }

    void FixedUpdate()
    {
        // Rotate the cube by converting the angles into a quaternion.
        Quaternion target = Quaternion.Euler(0, Input.GetAxis("Horizontal") * Angle, 0);

        if(Input.GetKey(KeyCode.UpArrow)){
            this.transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed);
            transform.position += Vector3.forward * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            this.transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed);
            transform.position += Vector3.back * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            this.transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed);
            transform.position += Vector3.left * Time.deltaTime * speed;
        }
        if(Input.GetKey(KeyCode.RightArrow)){ 
            this.transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * speed);
            transform.position += Vector3.right * Time.deltaTime * speed;
        }
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            count++;
        
            other.gameObject.SetActive(false); // to hide coin when collided 
        }
    }
    

    
}
*/