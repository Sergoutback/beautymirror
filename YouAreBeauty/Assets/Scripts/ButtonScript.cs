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

    // public GameObject drugoiObiekt;
    public ArrayOfCompliments arrOfCompl;
    // public string ansScript2;
    // public string ansScript2;
       
    public void Start()
    {
        TextAnswer.text =("What do you want?").ToString();
        arrOfCompl = GetComponent<ArrayOfCompliments>();
        // arrOfCompl.TextArr();
        // public ArrayOfCompliments arrOfCompl;
        // arrOfCompl = GetComponent<ArrayOfCompliments>();
        // arrOfCompl.randText();
        
    }

    // Update is called once per frame
    public void On_Click_button()
    {  
        // arrOfCompl = GetComponent<ArrayOfCompliments>();
        // arrOfCompl = drugoiObiekt.GetComponent<ArrayOfCompliments>();
        // arrOfCompl.textArrOfCompl  = ;
        // ansScript2 =  (arrOfCompl.randText()).ToString;
        arrOfCompl.TextArr();
        TextAnswer.text = arrOfCompl.TextArrOfCompl.text;
        
        // TextAnswer.text =("Yes, of course! \nYou are\nso beauty!").ToString();
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
