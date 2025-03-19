using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Food2 : MonoBehaviour
{
    public Text skor;
    int puan = 0;
    int hedef_puan = 300;
    AudioSource Ses;
    GameObject yilan;


    void Start()
    {
        InvokeRepeating("YemKonum", 0, 7f);
        Ses = GetComponent<AudioSource>();
        yilan = GameObject.FindGameObjectWithTag("Snake");

    }


    void FixedUpdate()
    {
        if (puan >= 100) { yilan.gameObject.GetComponent<Snake2>().hiz = 3.5f; }
        
        if (puan >= 150)
        {
            yilan.gameObject.GetComponent<Snake2>().hiz = 0f;
            SceneManager.LoadScene(7);
        }
    }
    void YemKonum()
    {
        float X = Random.Range(-8.4f, 8f);
        float Z = Random.Range(-4.50f, 4.50f);

        Vector3 Kordinat = new Vector3(X, 0.2f, Z);
        transform.position = Kordinat;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Snake")
        {
            CancelInvoke();
            InvokeRepeating("YemKonum", 0, 7f);
            puan += 10;
            skor.text = ("Skor : " + puan);
            Ses.Play();
            //Debug.Log("ok");
        }
    }
}
