using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Windows.Forms;
using UnityEngine;
using UnityEngine.UI;

public class ArrayOfCompliments : MonoBehaviour
{
    public  Text  TextArrOfCompl;
    public string text;
    // public string ansScript2;


    public void TextArr()
    {
        TextArrOfCompl.text = ("Script2 start").ToString();
        // string ansScript2 = TextArrOfCompl.text;
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