using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bomb : MonoBehaviour
{

    GameObject Ses;
    GameObject Yilan;
    


    private void Start()
    {
        Ses = GameObject.FindGameObjectWithTag("BombSes") ;
        Yilan = GameObject.FindGameObjectWithTag("Snake");
        
    }

    public void BombaKonum()
    {

        gameObject.SetActive(true);
        float X = Random.Range(-8.4f, 8f);
        float Z = Random.Range(-4.50f, 4.50f);

        Vector3 Kordinat = new Vector3(X, 0.2f, Z);
        transform.position = Kordinat;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Snake")
        {
            
            Yilan.gameObject.GetComponent<Snake4>().hiz = 0f;
            
            Ses.GetComponent<AudioSource>().Play();
            Ses.GetComponent<BombSes>().bombasonucusahneyukle();
            gameObject.SetActive(false);

        }
    }
   
}
