using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrayOfCompliments : MonoBehaviour
{
    public  Text  TextArrOfCompl;
    public string text;
  
  
    public void TextArr()
    {
        // TextArrOfCompl.text = ("Script2 start").ToString();
        List<string> myArr = new List<string>
            {
            "Yes, of course! \nYou are\nso beauty!",
            "Саша",
            "Костя",
            "Маша",
            "Никита",
            "Диана",
            "Даша",
            "Лёша",
            "Влад Быков",
            "Влад Волков",
            };
            System.Random rand = new System.Random();

                for (int i = myArr.Count; i > 0; i--)
                {
                    int flag = rand.Next(myArr.Count);
                    TextArrOfCompl.text = (myArr[flag]);
                    myArr.RemoveAt(flag);
                }
    }
}





// namespace WindowsFormsApplication1
// {
//     public partial class Form1 : Form
//     {
//         public Form1()
//         {
//             InitializeComponent();
//             randText();
//         }
//         public void randText()
//         {
//             List<string> myArr = new List<string>
//             {
//              "Вика",
//             "Саша",
//             "Костя",
//             "Маша",
//             "Никита",
//             "Диана",
//             "Даша",
//             "Лёша",
//             "Влад Быков",
//             "Влад Волков",
//             };
//             Random rand = new Random();
//             for (int i = myArr.Count; i > 0; i--)
//             {
//                 int flag = rand.Next(myArr.Count);
//                 textBox1.Text += s + Environment.NewLine;
//                 myArr.RemoveAt(flag);
//             }
//         }
 
//         private void button1_Click(object sender, EventArgs e)
//         {
//             this.Close();
//         }
//     }
// }