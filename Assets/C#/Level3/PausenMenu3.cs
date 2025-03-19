using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausenMenu3 : MonoBehaviour
{
    public GameObject Panel;
    void Start()
    {
        Panel.SetActive(false);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Oyunduraklat();
        }
    }
    void Oyunduraklat()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            Panel.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            Panel.SetActive(false);
        }
    }

    public void DevamEtButon3()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
    public void TekrarDene3()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1;
    }
    public void AnaMenuButon3()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void levelmenuButon3()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
   
}
