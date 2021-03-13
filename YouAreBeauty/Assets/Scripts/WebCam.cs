﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    int currentCamIndex = 0;
    WebCamTexture tex;
    public RawImage display;
    public Text startStopText;
    
    public void SwapCam_Cliked()
    {
        if (tex != null)
        {                
            if (WebCamTexture.devices.Length >0)
            {
                currentCamIndex += 1;
                currentCamIndex %= WebCamTexture.devices.Length;

                // if tex is not null:
                // stop the web cam
                // start the web cam
                if (tex != null)
                {
                    StopWebCam();
                    StartStopCam_Cliked();
                }
            }
        }
    }

    public void StartStopCam_Cliked()
    {   
        if (tex != null) // Stop the camera
        {
            StopWebCam();
            startStopText.text = "Start Camera";
            // display.texture = null;
            // tex.Stop();
            // tex = null;
            // startStopText.text = "Start Camera";
        }
        else  // Start the camera
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;

            // float antiRotate = -(360 - tex.videoRotationAngle);
            // Quaternion quatRot = new Quaternion();
            // quatRot.eulerAngles = new Vector3(0, 0, antiRotate);
            // display.transform.rotation = quatRot;

            tex.Play();
            startStopText.text = "Stop Camera";
        }
    }

    public void StopWebCam()
    {
        display.texture = null;
        tex.Stop();
        tex = null;
    }

   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
