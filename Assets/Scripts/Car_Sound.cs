using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Sound : MonoBehaviour
{
    public float minSpeed;
    public float maxSpeed;
    private float currentSpeed;


    private Rigidbody carRb;
    private AudioSource carAudio;



    public float minPitch;
    public float maxPitch;
    private float pitchFromCar;

    void Start()
    {
        carAudio = GetComponent<AudioSource>();
        carRb = GetComponent<Rigidbody>();
        
    }
    void Update()
    {

        Debug.Log("Update running");
        EngineSound();
        
    }
    void EngineSound()
    {
        currentSpeed = carRb.velocity.magnitude;
        pitchFromCar = currentSpeed / 50f;


/*
        if (currentSpeed < 0.1f)
    {
        if (carAudio.isPlaying)
        {
            carAudio.Stop(); // stop when car is still
        }
        return;
    }
*/
    if (!carAudio.isPlaying)
    {
        carAudio.Play(); // play only if not already playing
    }



         if(currentSpeed < minSpeed)
         {
            carAudio.pitch = minPitch;
         }

         if(currentSpeed > minSpeed && currentSpeed < maxSpeed)
         {
            carAudio.pitch = minPitch + pitchFromCar;
         }

         if (currentSpeed > maxSpeed)
         {
            carAudio.pitch = maxPitch;
         }
    }
}
