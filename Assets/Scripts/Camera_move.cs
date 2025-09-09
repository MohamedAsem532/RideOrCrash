using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    public Camera Camera4;

    void Start()
    {
        // Initialize camera states
        Camera4.enabled = false;
        Camera3.enabled = false;
        Camera2.enabled = false;
        Camera1.enabled = true;
    }

    void Update()
    {
        // Switch cameras on key press
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(Camera1, Camera2, Camera3, Camera4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(Camera2, Camera1, Camera3, Camera4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchCamera(Camera3, Camera1, Camera2, Camera4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SwitchCamera(Camera4, Camera1, Camera2, Camera3);
        }
    }

    // Switch between cameras
    void SwitchCamera(Camera activeCam, Camera cam1, Camera cam2, Camera cam3)
    {
        activeCam.enabled = true;
        cam1.enabled = false;
        cam2.enabled = false;
        cam3.enabled = false;

        SetAudioListener(activeCam, true);
        SetAudioListener(cam1, false);
        SetAudioListener(cam2, false);
        SetAudioListener(cam3, false);
    }
    void SetAudioListener(Camera cam, bool state)
    {
        AudioListener listener = cam.GetComponent<AudioListener>();
        if (listener != null)
            listener.enabled = state;
    }
}