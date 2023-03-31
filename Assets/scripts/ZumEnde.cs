using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZumEnde : MonoBehaviour
{
    public GameObject DialogKamera;
    public GameObject Spieler;
    public GameObject Dialogback;
    public GameObject TextZumDungeon;
    public GameObject Fade;
    public GameObject Etaste;
    public AudioSource Mumble;
    public AudioSource Whoosh;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(Dungeonlego());
        }
    }

    IEnumerator Dungeonlego()
    {
        Mumble.Play();
        Spieler.SetActive(false);
        DialogKamera.SetActive(true);
        Dialogback.SetActive(true);
        TextZumDungeon.SetActive(true);
        yield return new WaitForSeconds(3);
        Etaste.SetActive(true);
    }

    void Update()
    {
        if(Etaste.activeSelf && TextZumDungeon.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(DialogP232());
        }
    }

    IEnumerator DialogP232()
    {
        Dialogback.SetActive(false);
        TextZumDungeon.SetActive(false);
        Fade.SetActive(true);
        Whoosh.Play();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Dungeon");
    }
}
