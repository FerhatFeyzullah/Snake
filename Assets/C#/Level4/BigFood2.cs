using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class BigFood2 : MonoBehaviour
{

    GameObject bgsesobje;
    GameObject yilan;
    public bool topcagirildi = false;

    GameObject yem;


    void Start()
    {
        // Start metodunda renk deðiþimini baþlatabilirsiniz
        InvokeRepeating("RenkDegistirme", 0f, 1f); // Her saniyede bir RenkDegistirme metodu çaðrýlýr
        //gameObject.SetActive(false);
        topcagirildi = false;
        yem = GameObject.FindGameObjectWithTag("Food");
        bgsesobje = GameObject.FindGameObjectWithTag("BigFoodSes");
    }

    void RenkDegistirme()
    {
        // Rastgele bir renk seç
        Color yeniRenk = new Color(Random.value, Random.value, Random.value);

        // Materyali al ve rengini deðiþtir
        GetComponent<Renderer>().material.color = yeniRenk;
    }

    public void BuyukYemKonum()
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
            
            gameObject.SetActive(false);
            yem.GetComponent<Food4>().puan += 30;
            bgsesobje.GetComponent<BigFoodSes>().bgsescal();


        }
    }
}
