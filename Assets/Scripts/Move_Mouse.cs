/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Move_Mouse : MonoBehaviour
{
    Vector3 goal;
    float speed=3;
    private int count;
    

  

    void Start()
    {
        
        
        goal=this.transform.position;
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0)){
            goal = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
        }
        Vector3 direction = goal - this.transform.position;
        if (Vector3.Distance(transform.position, goal) > 0.5){
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, 
            Quaternion.LookRotation(direction), Time.deltaTime * speed);
            
            this.transform.Translate(0,0, speed*Time.deltaTime);
            // this.transform.position += new Vector3(0,0,speed*Time.deltaTime);
        }
    }



}
    //void OnTriggerEnter(Collider other)
   //{
        //if (other.gameObject.CompareTag("Coin"))
        //{
          //  count++;
        
            //other.gameObject.SetActive(false); // to hide coin when collided 
        //}
   // }
   */
    