using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FromMainToScreen : MonoBehaviour
{
    public void ChangeFromMainToScreenshot()
    {
        SceneManager.LoadScene(2);
    }    
}
