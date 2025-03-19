using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading1 : MonoBehaviour
{
    public Image loading;
    public float barmax;
    float bar;
    public float bar_yuklemehizi = 5;
    void Start()
    {
        bar = 1;
    }


    void Update()
    {
        bar += bar_yuklemehizi * 2 * Time.deltaTime;
        loading.fillAmount = bar / barmax;

        if (bar >= barmax)
        {
            SceneManager.LoadScene(4);
        }

    }
}
