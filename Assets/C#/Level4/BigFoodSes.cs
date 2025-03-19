using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigFoodSes : MonoBehaviour
{
    AudioSource bgses;

    void Start()
    {
        bgses=gameObject.GetComponent<AudioSource>();   
    }


     public void bgsescal()
    {
        bgses.Play();
    }
}
