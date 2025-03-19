using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Food5 : MonoBehaviour
{
    public Text skor;
    public int puan = 0;
    int hedef_puan = 300;
    AudioSource Ses;
    GameObject yilan;
    GameObject buyukyem, bomba;
    int buyuktopgelmesayisi;



    void Start()
    {
        InvokeRepeating("YemKonum", 0, 7f);
        Ses = GetComponent<AudioSource>();
        yilan = GameObject.FindGameObjectWithTag("Snake");
        buyukyem = GameObject.FindGameObjectWithTag("BigFood");
        buyuktopgelmesayisi = 0;

    }

    void Update()
    {
        if (puan >= 100) { yilan.gameObject.GetComponent<Snake5>().hiz = 3.5f; }
       
        if (puan >= 150)
        {
            yilan.gameObject.GetComponent<Snake5>().hiz = 0f;
            SceneManager.LoadScene(13);

        }

        if (puan == 50 && buyukyem.GetComponent<BigFood3>().topcagirildi == false && buyuktopgelmesayisi == 0)
        {
            buyuktopgelmesayisi++;
            Debug.Log("topgeldimi");
            buyukyem.gameObject.SetActive(true);
            buyukyem.GetComponent<BigFood3>().BuyukYemKonum();
            buyukyem.GetComponent<BigFood3>().topcagirildi = true;
            StartCoroutine(BuyukTopGeldi());
        }
        if (puan == 100 && buyukyem.GetComponent<BigFood3>().topcagirildi == false && buyuktopgelmesayisi == 1)
        {
            Debug.Log("topgeldimi");
            buyukyem.gameObject.SetActive(true);
            buyukyem.GetComponent<BigFood3>().BuyukYemKonum();
            buyukyem.GetComponent<BigFood3>().topcagirildi = true;
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
        buyukyem.GetComponent<BigFood3>().topcagirildi = false;
        buyukyem.gameObject.SetActive(false);
    }
}
