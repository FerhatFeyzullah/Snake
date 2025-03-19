using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaCagirma2 : MonoBehaviour
{
    GameObject bomba;
    void Start()
    {
        bomba = GameObject.FindGameObjectWithTag("Bomb");
        InvokeRepeating("bombagetir", 7f, 7f);
    }
    void bombagetir()
    {
        bomba.gameObject.SetActive(true);
        bomba.GetComponent<Bomb2>().BombaKonum();
        //StartCoroutine(BombaGeldi());

    }
    /*IEnumerator BombaGeldi()
    {
        yield return new WaitForSeconds(7);

        bomba.gameObject.SetActive(false);
    }
    */
}
