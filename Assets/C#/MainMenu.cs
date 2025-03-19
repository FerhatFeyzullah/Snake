using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


     
    public void Baslat()
    {
        SceneManager.LoadScene(3);
    }
    public void Leveller()
    {
        SceneManager.LoadScene(2);
    }
    public void exitgame0()
    {
        Application.Quit();
    }

    
}
