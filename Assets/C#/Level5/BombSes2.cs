using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BombSes2 : MonoBehaviour
{
    public void bombasonucusahneyukle()
    {
        StartCoroutine(BombaYenildi());

    }
    IEnumerator BombaYenildi()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(12);
    }
}
