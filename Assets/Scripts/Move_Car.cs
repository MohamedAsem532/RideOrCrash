using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Move : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;


    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;


   
    [SerializeField] GameObject wheelEffectObjBR;
    [SerializeField] GameObject wheelEffectObjBL;

    public float acceleration = 10000f;
    public float breakForcing = 5000f;
    public float maxTurnAngle = 100f;
    public float speed = 3.0f;


    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    public AudioSource brakeSound;
    

    /*
        public float speed;
        private float turnSpeed = 45.0f ;
        private float horizontalInput;
        private float forwardInput;

        */

    void FixedUpdate()
    {

        //Get forward and reverse acceleration W/S
        currentAcceleration = speed * acceleration * Input.GetAxis("Vertical");


        //If we press space , give currentBreakingForce a value.
        if (Input.GetKey(KeyCode.Space))
        {
            currentBreakForce = breakForcing;
            
        }
        else
        {
            brakeSound.Play();
            currentBreakForce = 0f;
        }


        //Apply acceleration to back wheels.       
        backRight.motorTorque = currentAcceleration;
        backLeft.motorTorque = currentAcceleration;

        //Apply breaking to all wheels.
        frontRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;


        // Take care of steering A/D
        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");

        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;


        // Update wheel meshes.
        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontRight, frontRightTransform);
        UpdateWheel(backLeft, backLeftTransform);
        UpdateWheel(backRight, backRightTransform);



        WheelEffects();

    }


    void UpdateWheel(WheelCollider col, Transform trans)
    {
        // Get wheel collider state.
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        // Set wheel transformation state
        trans.position = position;
        trans.rotation = rotation;

    }

    void WheelEffects()  // for effects after braking
    {
           bool isBraking = Input.GetKey(KeyCode.Space);

      
            wheelEffectObjBR.GetComponentInChildren<TrailRenderer>().emitting =isBraking;
            wheelEffectObjBL.GetComponentInChildren<TrailRenderer>().emitting =isBraking;       
      
    }


}
