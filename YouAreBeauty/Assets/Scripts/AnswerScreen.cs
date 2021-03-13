using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerScreen : MonoBehaviour
{
    // public float timeLeft;
    // public int forStartTimer;
    public Text TextAnswerScreen;
    public string text;
    public ArrayOfCompliments arrOfCompl;

       
    public void Start()
    {
        // TextAnswer.text =("What do you want?").ToString();
        arrOfCompl = GetComponent<ArrayOfCompliments>();
    }

  
    public void AnswerOnScreen()
    {  
        arrOfCompl.TextArr();
        TextAnswerScreen.text = arrOfCompl.TextArrOfCompl.text;
        
        // TextAnswer.text =("Yes, of course! \nYou are\nso beauty!").ToString();
        // forStartTimer = 2;
        // Handheld.Vibrate(); 
        // timeLeft = 3;
        
        // ScreenCapture.CaptureScreenshot("SomeLevel");
        
    }   

    // public void Update()
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

}
