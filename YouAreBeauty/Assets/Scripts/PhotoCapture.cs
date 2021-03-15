﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoCapture : MonoBehaviour
{
    public Camera captureCamera;

    public void MakeScrenshot() 
    {
        int width = this.captureCamera.pixelWidth;
        int height = this.captureCamera.pixelHeight;
        Texture2D texture = new Texture2D(width, height);
        RenderTexture targetTexture = RenderTexture.GetTemporary(width, height);
        this.captureCamera.targetTexture = targetTexture;
        this.captureCamera.Render();
        RenderTexture.active = targetTexture;
        Rect rect = new Rect(0, 0, width, height);
        texture.ReadPixels(rect, 0, 0);
        texture.Apply();
    }

    
}
