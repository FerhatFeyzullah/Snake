using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFoodSes2 : MonoBehaviour
{
    AudioSource bgses;

    void Start()
    {
        bgses = gameObject.GetComponent<AudioSource>();
    }


    public void bgsescal1()
    {
        bgses.Play();
    }

}
