using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Sound : MonoBehaviour
{

public AudioSource coinSound;
    void OnTriggerEnter(Collider other)
{
        if (other.gameObject.CompareTag("Coin"))
    {    
            coinSound.Play();
            other.gameObject.SetActive(false); // to hide coin when collided 
            
          
    }
}
}
