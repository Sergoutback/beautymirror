using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerScreen : MonoBehaviour
{
    // public Texture[] textures;
    // public float changeInterval = 0.33F;
    // public Renderer rend;
    // WebCamTexture texScreen;
    // public RawImage displayScreen;
    // public int superSize = 2;
    // private int _shotIndex = 0;
  
    public Text TextAnswerScreen;
    public string text;
    public ArrayOfCompliments arrOfCompl;

       
    public void Start()
    {
        arrOfCompl = GetComponent<ArrayOfCompliments>();
        arrOfCompl.TextArr();
        TextAnswerScreen.text = arrOfCompl.TextArrOfCompl.text;
        // ScreenCapture.CaptureScreenshot($"Screenshot{_shotIndex}.png", superSize);
        // _shotIndex++;
        // Debug.Log(Application.persistentDataPath);
        // var texture : Texture;
        // renderer.material.mainTexture = texture;
        // rend = GetComponent<Renderer>();
    }
    //     public void Update()
    // {
    //      if (textures.Length == 0)
    //      return;

    //     int index = Mathf.FloorToInt(Time.time / changeInterval);
    //     index = index % textures.Length;
    //     rend.material.mainTexture = textures[index];
        
    // }

  
    // public void AnswerOnScreen()
    // {  
    //     arrOfCompl.TextArr();
    //     TextAnswerScreen.text = arrOfCompl.TextArrOfCompl.text;
    // }    
} 



