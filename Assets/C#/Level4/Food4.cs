using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Food4 : MonoBehaviour
{
    public Text skor;
    public int puan = 0;
    int hedef_puan = 300;
    AudioSource Ses;
    GameObject yilan;
    GameObject buyukyem,bomba;
    int buyuktopgelmesayisi;



    void Start()
    {
        InvokeRepeating("YemKonum", 0, 7f);
        Ses = GetComponent<AudioSource>();
        yilan = GameObject.FindGameObjectWithTag("Snake");
        buyukyem = GameObject.FindGameObjectWithTag("BigFood");
        buyuktopgelmesayisi = 0;              
        
    }

    void FixedUpdate()
    {
        if (puan >= 100) { yilan.gameObject.GetComponent<Snake4>().hiz = 3.7f; }
               
        if (puan >= 250)
        {
            yilan.gameObject.GetComponent<Snake4>().hiz = 0f;
            SceneManager.LoadScene(11);

        }

        if (puan == 50 && buyukyem.GetComponent<BigFood2>().topcagirildi == false && buyuktopgelmesayisi == 0)
        {
            buyuktopgelmesayisi++;
            Debug.Log("topgeldimi");
            buyukyem.gameObject.SetActive(true);
            buyukyem.GetComponent<BigFood2>().BuyukYemKonum();
            buyukyem.GetComponent<BigFood2>().topcagirildi = true;
            StartCoroutine(BuyukTopGeldi());
        }
        if (puan == 100 && buyukyem.GetComponent<BigFood2>().topcagirildi == false && buyuktopgelmesayisi == 1)
        {
            Debug.Log("topgeldimi");
            buyukyem.gameObject.SetActive(true);
            buyukyem.GetComponent<BigFood2>().BuyukYemKonum();
            buyukyem.GetComponent<BigFood2>().topcagirildi = true;
            StartCoroutine(BuyukTopGeldi());
        }
        if (puan == 150 && buyukyem.GetComponent<BigFood2>().topcagirildi == false && buyuktopgelmesayisi == 2)
        {
            Debug.Log("topgeldimi");
            buyukyem.gameObject.SetActive(true);
            buyukyem.GetComponent<BigFood2>().BuyukYemKonum();
            buyukyem.GetComponent<BigFood2>().topcagirildi = true;
            StartCoroutine(BuyukTopGeldi());
        }
        if (puan == 200 && buyukyem.GetComponent<BigFood2>().topcagirildi == false && buyuktopgelmesayisi == 3)
        {
            Debug.Log("topgeldimi");
            buyukyem.gameObject.SetActive(true);
            buyukyem.GetComponent<BigFood2>().BuyukYemKonum();
            buyukyem.GetComponent<BigFood2>().topcagirildi = true;
            StartCoroutine(BuyukTopGeldi());
        }


        skor.text = ("Skor : " + puan);

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

    IEnumerator BuyukTopGeldi()
    {
        yield return new WaitForSeconds(10);
        buyukyem.GetComponent<BigFood2>().topcagirildi = false;
        buyukyem.gameObject.SetActive(false);
    }
    

}
