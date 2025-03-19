using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    int harita_num;
    public GameObject Haritalar1, Haritalar2, Haritalar3, Haritalar4, Haritalar5;
    

    
      void Start()
    {
        harita_num = 1;
        
    }

     void Update()
    {
        if (harita_num <= 1) { harita_num = 1; }
        if (harita_num >= 5) { harita_num = 5; }

        if (harita_num == 1)
        {
            Haritalar1.gameObject.SetActive(true);
            Haritalar2.gameObject.SetActive(false);
            Haritalar3.gameObject.SetActive(false);
            Haritalar4.gameObject.SetActive(false);
            Haritalar5.gameObject.SetActive(false);
        }
        if (harita_num == 2)
        {
            Haritalar1.gameObject.SetActive(false);
            Haritalar2.gameObject.SetActive(true);
            Haritalar3.gameObject.SetActive(false);
            Haritalar4.gameObject.SetActive(false);
            Haritalar5.gameObject.SetActive(false);
        }
        if (harita_num == 3)
        {
            Haritalar1.gameObject.SetActive(false);
            Haritalar2.gameObject.SetActive(false);
            Haritalar3.gameObject.SetActive(true);
            Haritalar4.gameObject.SetActive(false);
            Haritalar5.gameObject.SetActive(false);
        }
        if (harita_num == 4)
        {
            Haritalar1.gameObject.SetActive(false);
            Haritalar2.gameObject.SetActive(false);
            Haritalar3.gameObject.SetActive(false);
            Haritalar4.gameObject.SetActive(true);
            Haritalar5.gameObject.SetActive(false);
        }
        if (harita_num == 5)
        {
            Haritalar1.gameObject.SetActive(false);
            Haritalar2.gameObject.SetActive(false);
            Haritalar3.gameObject.SetActive(false);
            Haritalar4.gameObject.SetActive(false);
            Haritalar5.gameObject.SetActive(true);
        }

    }

    public void sag_buton()
    {
        harita_num++;
        Debug.Log("+1");
    }

    public void sol_buton()
    {
        harita_num--;
        Debug.Log("-1");
    }

    public void playbuton()
    {
        if (harita_num == 1) { SceneManager.LoadScene(3); }
        if (harita_num == 2) { SceneManager.LoadScene(5); }
        if (harita_num == 3) { SceneManager.LoadScene(7); }
        if (harita_num == 4) { SceneManager.LoadScene(9); }
        if (harita_num == 5) { SceneManager.LoadScene(11); }
    }

    public void anamenudonus()
    {
        SceneManager.LoadScene(1);
    }
}
