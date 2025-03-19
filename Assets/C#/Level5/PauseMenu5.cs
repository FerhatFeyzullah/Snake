using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu5 : MonoBehaviour
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

    public void DevamEtButon5()
    {
        Time.timeScale = 1;
        Panel.SetActive(false);
    }
    public void TekrarDene5()
    {
        SceneManager.LoadScene(12);
        Time.timeScale = 1;
    }
    public void AnaMenuButon5()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
    public void levelmenuButon5()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1;
    }
    
}
