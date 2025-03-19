using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wall5 : MonoBehaviour
{
    AudioSource music;
    GameObject Yilan;
    private void Start()
    {
        music = GetComponent<AudioSource>();
        Yilan = GameObject.FindGameObjectWithTag("Snake");

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Snake")
        {
            music.Play();
            Yilan.gameObject.GetComponent<Snake5>().hiz = 0f;
            StartCoroutine(Duvara_Carpildi());
            Debug.Log("ok");
        }
    }

    IEnumerator Duvara_Carpildi()
    {
        yield return new WaitForSeconds(1.7f);
        SceneManager.LoadScene(12);
    }
}
