using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{
    int currentCamIndex = 0;
    WebCamTexture tex;
    public RawImage display;

    public void SwapCam_Cliked()
    {
        if (WebCamTexture.devices.Length >0)
        {
            currentCamIndex += 1;
            currentCamIndex %= WebCamTexture.devices.Length;
        }
    }

    public void StartStopCam_Cliked()
    {   
        if (tex != null)
        {
            display.texture = null;
            tex.Stop();
            tex = null;
        }
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCamIndex];
            WebCamTexture camTexture = new WebCamTexture(device.name);
            display.texture = tex;

            tex.Play();
        }
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
