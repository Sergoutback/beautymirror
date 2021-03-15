using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnswerMain : MonoBehaviour
{
    public Text TextAnswer;
    public string text;
    public ArrayOfCompliments arrOfCompl;
    public WebCam webCamStop;
    // public FromMainToScreen fromMainToScreen;
    public int forStopWebCam;

       
    public void Start()
    {
        TextAnswer.text =("What do you want?").ToString();
        // webCamStop = GetComponent<WebCam>();
        // fromMainToScreen = GetComponent<FromMainToScreen>();
    }

  
    public void On_Click_button()
    {        
        Handheld.Vibrate(); 
        // fromMainToScreen.ChangeFromMainToScreenshot();       
    }   
}