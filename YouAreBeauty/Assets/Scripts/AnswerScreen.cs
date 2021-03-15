using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerScreen : MonoBehaviour
{
    public Texture[] textures;
    public float changeInterval = 0.33F;
    public Renderer rend;
    WebCamTexture texScreen;
    public RawImage displayScreen;
    public int superSize = 2;
    private int _shotIndex = 0;
    // public float timeLeft;
    // public int forStartTimer;
    public Text TextAnswerScreen;
    public string text;
    public ArrayOfCompliments arrOfCompl;

       
    public void Start()
    {
        // Take a "screenshot" of a camera's Render Texture.
        Texture2D RTImage(Camera camera)
        {
            // The Render Texture in RenderTexture.active is the one
            // that will be read by ReadPixels.
            var currentRT = RenderTexture.active;
            RenderTexture.active = camera.targetTexture;

            // Render the camera's view.
            camera.Render();

            // Make a new texture and read the active Render Texture into it.
            Texture2D image = new Texture2D(camera.targetTexture.width, camera.targetTexture.height);
            image.ReadPixels(new Rect(0, 0, camera.targetTexture.width, camera.targetTexture.height), 0, 0);
            image.Apply();

            // Replace the original active Render Texture.
            RenderTexture.active = currentRT;
            return image;
        }
        // TextAnswer.text =("What do you want?").ToString();
        arrOfCompl = GetComponent<ArrayOfCompliments>();
        arrOfCompl.TextArr();
        TextAnswerScreen.text = arrOfCompl.TextArrOfCompl.text;
        ScreenCapture.CaptureScreenshot($"Screenshot{_shotIndex}.png", superSize);
        _shotIndex++;
        Debug.Log(Application.persistentDataPath);
        // var texture : Texture;
        // renderer.material.mainTexture = texture;
        rend = GetComponent<Renderer>();
    }
        public void Update()
    {
         if (textures.Length == 0)
         return;

        int index = Mathf.FloorToInt(Time.time / changeInterval);
        index = index % textures.Length;
        rend.material.mainTexture = textures[index];
        
    }

  
    public void AnswerOnScreen()
    {  
        arrOfCompl.TextArr();
        TextAnswerScreen.text = arrOfCompl.TextArrOfCompl.text;
    }    
} 
        // TextAnswer.text =("Yes, of course! \nYou are\nso beauty!").ToString();
        // forStartTimer = 2;
        // Handheld.Vibrate(); 
        // timeLeft = 3;
        
        // ScreenCapture.CaptureScreenshot("SomeLevel");
        
     

    // public void Update()
    // {

    // }
    // {
    //     if (forStartTimer == 2)
    //     {      
    //         timeLeft -= Time.deltaTime;  
    //         {      
    //         if (timeLeft < 0)
    //             {
    //                 TextAnswer.text =("What do you want?").ToString();
    //             }
    //         }
           
    //     }
        
    // }


