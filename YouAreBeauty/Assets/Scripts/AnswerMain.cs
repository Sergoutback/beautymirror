using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerMain : MonoBehaviour
{
    public float timeLeft;
    public int forStartTimer;
    public Text TextAnswer;
    public string text;
    public ArrayOfCompliments arrOfCompl;
    public WebCam webCamStop;
    public FromMainToScreen fromMainToScreen;
    public int forStopWebCam;

       
    public void Start()
    {
        TextAnswer.text =("What do you want?").ToString();
        // arrOfCompl = GetComponent<ArrayOfCompliments>();
        webCamStop = GetComponent<WebCam>();
        fromMainToScreen = GetComponent<FromMainToScreen>();
    }

  
    public void On_Click_button()
    {  
        // arrOfCompl.TextArr();
        // TextAnswer.text = arrOfCompl.TextArrOfCompl.text;
        
        // forStartTimer = 2;
        Handheld.Vibrate(); 
        // timeLeft = 3;
        fromMainToScreen.ChangeFromMainToScreenshot();
        
    }   
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
                   
    // public void ChangeScene()
    // {  
    //     fromMainToScreen.ChangeFromMainToScreenshot();
    //     webCamStop.StopWebCam();                       
    // }       
 
