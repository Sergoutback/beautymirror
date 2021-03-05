using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text TextAnswer;
    public string text;
    // public object TextAnswer { get; private set; }

    // Start is called before the first frame update
    public void Start()
    {
        TextAnswer.text =("Тебе чего?").ToString();
        
    }

    // Update is called once per frame
    public void On_Click_button()
    {
        TextAnswer.text =("Конечно да! \nТы самая\nкрасивая!").ToString();
        Handheld.Vibrate();  
    }
}
