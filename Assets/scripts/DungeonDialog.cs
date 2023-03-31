using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DungeonDialog : MonoBehaviour
{
    public GameObject DialogKamera;
    public GameObject Spieler;
    public GameObject Dialogback;
    public GameObject TextImDungeon;
    public GameObject Fade;
    public GameObject Witch;
    public GameObject Etaste;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StartCoroutine(DungeonHexe());
        }
    }

    IEnumerator DungeonHexe()
    {
        Spieler.SetActive(false);
        DialogKamera.SetActive(true);
        Dialogback.SetActive(true);
        TextImDungeon.SetActive(true);
        yield return new WaitForSeconds(3);
        Etaste.SetActive(true);
    }

    void Update()
    {
        if(Etaste.activeSelf && TextImDungeon.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(DialogP2324());
        }
    }

    IEnumerator DialogP2324()
    {
        Dialogback.SetActive(false);
        TextImDungeon.SetActive(false);
        Etaste.SetActive(false);
        Fade.SetActive(true);
        yield return new WaitForSeconds(2);
        Fade.SetActive(false);
        Spieler.SetActive(true);
        DialogKamera.SetActive(false);        
        Witch.SetActive(false);
    }
}
