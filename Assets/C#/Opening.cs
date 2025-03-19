using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opening : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(AnaMenuGecis());
    }

   IEnumerator AnaMenuGecis()
    {
        yield return new WaitForSeconds(4);
        
        SceneManager.LoadScene(1);
    }
}
