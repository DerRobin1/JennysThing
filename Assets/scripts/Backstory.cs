using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backstory : MonoBehaviour
{
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        StartCoroutine(Infos());
    }

    IEnumerator Infos()
    {
        T1.SetActive(true);
        yield return new WaitForSeconds(5);
        T1.SetActive(false);
        T2.SetActive(true);
        yield return new WaitForSeconds(5);
        T2.SetActive(false);
        T3.SetActive(true);
        yield return new WaitForSeconds(5);
        T3.SetActive(false);
        T4.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("Menu");
    }
    
}
