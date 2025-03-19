using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Snake3 : MonoBehaviour
{
    public float hiz = 3f;

    public GameObject kuyruk;
    List<GameObject> kuyruklar;
    Vector3 eskikonum;
    GameObject cikankuyruk;
    AudioSource muzik;
    private Vector3 hareketYonu;

    public Button sagaButton;
    public Button solaButton;
    public Button yukariButton;
    public Button asagiButton;

    void Start()
    {
        muzik = GetComponent<AudioSource>();
        kuyruklar = new List<GameObject>();
        for (int i = 0; i < 3; i++)
        {
            GameObject yeni_kuyruk = Instantiate(kuyruk, eskikonum, Quaternion.identity);
            kuyruklar.Add(yeni_kuyruk);



        }
        InvokeRepeating("Hareket_Et", 0, 0.1f);
        hareketYonu = Vector3.up; // Baþlangýçta yýlanýn dikey hareket ettiðini varsayalým

        //sagaButton.onClick.AddListener(SagaDon);
        //solaButton.onClick.AddListener(SolaDon);
        //yukariButton.onClick.AddListener(YukariDon);
        //asagiButton.onClick.AddListener(AsagiDon);
    }

    void Hareket_Et()
    {
        eskikonum = transform.position;
        if (kuyruklar.Count > 0)
        {
            kuyruklar[0].transform.position = eskikonum;

            cikankuyruk = kuyruklar[0];
            kuyruklar.RemoveAt(0);
            kuyruklar.Add(cikankuyruk);

        }
    }


    void Update()
    {
        transform.Translate(0, 0, hiz * Time.deltaTime);

        HareketKontrol();


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            GameObject yeni_kuyruk = Instantiate(kuyruk, eskikonum, Quaternion.identity);
            kuyruklar.Add(yeni_kuyruk);

            //Debug.Log("ok");
        }
        if (other.gameObject.tag == "BigFood")
        {
            GameObject yeni_kuyruk = Instantiate(kuyruk, eskikonum, Quaternion.identity);
            kuyruklar.Add(yeni_kuyruk);
            GameObject yeni_kuyruk2 = Instantiate(kuyruk, eskikonum, Quaternion.identity);
            kuyruklar.Add(yeni_kuyruk2);

            //Debug.Log("ok");
        }
        if (other.gameObject.tag == "Kuyruk")
        {
            muzik.Play();
            hiz = 0;
            StartCoroutine(Kuyruga_Carpildi());

            //Debug.Log("ok");
        }
    }

    IEnumerator Kuyruga_Carpildi()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(8);
    }

    void HareketKontrol()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 yeniHareketYonu = new Vector3(yatay, 0f, dikey).normalized;

        // Yýlanýn tam arkasýna dönmesini engelle
        if (yatay != 0f || dikey != 0f)
        {
            if (!IsZitYon(hareketYonu, yeniHareketYonu))
            {
                hareketYonu = yeniHareketYonu;
                transform.rotation = Quaternion.LookRotation(hareketYonu, Vector3.up);
            }
        }

    }
    bool IsZitYon(Vector3 v1, Vector3 v2)
    {
        float dotProduct = Vector3.Dot(v1.normalized, v2.normalized);
        return Mathf.Approximately(dotProduct, -1f);
    }

    public void SagaDon()
    {
        //hareketYonu = Vector3.right;
        //transform.rotation = Quaternion.LookRotation(hareketYonu, Vector3.up);
        if (!IsZitYon(hareketYonu, Vector3.right))
        {
            hareketYonu = Vector3.right;
            transform.rotation = Quaternion.LookRotation(hareketYonu, Vector3.up);
        }
    }

    public void SolaDon()
    {
        if (!IsZitYon(hareketYonu, Vector3.left))
        {
            hareketYonu = Vector3.left;
            transform.rotation = Quaternion.LookRotation(hareketYonu, Vector3.up);
        }
    }

    public void YukariDon()
    {
        if (!IsZitYon(hareketYonu, Vector3.forward))
        {
            hareketYonu = Vector3.forward;
            transform.rotation = Quaternion.LookRotation(hareketYonu, Vector3.up);
        }
    }

    public void AsagiDon()
    {
        if (!IsZitYon(hareketYonu, Vector3.back))
        {
            hareketYonu = Vector3.back;
            transform.rotation = Quaternion.LookRotation(hareketYonu, Vector3.up);
        }
    }
}
