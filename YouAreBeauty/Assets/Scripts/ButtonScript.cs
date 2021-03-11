using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public float timeLeft;
    public int forStartTimer;
    public Text TextAnswer;
    public string text;
    // public object TextAnswer { get; private set; }

    // Start is called before the first frame update
    public void Start()
    {
        TextAnswer.text =("What do you want?").ToString();
        
    }

    // Update is called once per frame
    public void On_Click_button()
    {   
       TextAnswer.text =("Yes, of course! \nYou are\nso beauty!").ToString();
        forStartTimer = 1;
        Handheld.Vibrate(); 
        timeLeft = 2;
        
    }   

    public void Update()
    {
        if (forStartTimer == 1)
        {      
            timeLeft -= Time.deltaTime;  
            {      
            if (timeLeft < 0)
                {
                    TextAnswer.text =("What do you want?").ToString();
                }
            }

        }
        
    }

}
