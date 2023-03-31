using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KindTrigger1 : MonoBehaviour
{
    public GameObject DialogKamera;
    public GameObject Spieler;
    public GameObject Dialogback;
    public GameObject Text1;
    public GameObject Witch;
    public GameObject Fade;
    public GameObject UiAufgabe;
    public GameObject Count;
    public GameObject Etaste;
    public GameObject Bottles;
    public AudioSource Mumble;
    public AudioSource Whoosh;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Kind1());
        }
    }

    IEnumerator Kind1()
    {
        Mumble.Play();
        Spieler.SetActive(false);
        DialogKamera.SetActive(true);
        Dialogback.SetActive(true);
        Text1.SetActive(true);
        yield return new WaitForSeconds(3);
        Etaste.SetActive(true);
    }

    void Update()
    {
        if(Etaste.activeSelf && Text1.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(DialogP2());
        }
    }

    IEnumerator DialogP2()
    {
        Etaste.SetActive(false);
        Dialogback.SetActive(false);
        Text1.SetActive(false);
        Fade.SetActive(true);
        Whoosh.Play();
        yield return new WaitForSeconds(2);
        UiAufgabe.SetActive(true);
        Count.SetActive(true);
        DialogKamera.SetActive(false);
        Fade.SetActive(false);
        Bottles.SetActive(true);
        Spieler.SetActive(true);
        Witch.SetActive(false);
    }
}
