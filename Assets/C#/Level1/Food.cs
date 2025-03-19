using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Food : MonoBehaviour
{
    public Text skor;
    public int puan = 0;
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
        if (puan >= 80) { yilan.gameObject.GetComponent<Snake>().hiz = 3.5f; }
        if (puan >= 150) { yilan.gameObject.GetComponent<Snake>().hiz = 4f; }
        
        if (puan >= 200)
        { 
            yilan.gameObject.GetComponent<Snake>().hiz = 0f;
            SceneManager.LoadScene(5);

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
            puan +=10;
            skor.text = ("Skor : " + puan);
            Ses.Play(); 
            //Debug.Log("ok");
        }
    }
}
