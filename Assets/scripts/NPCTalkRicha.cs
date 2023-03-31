using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalkRicha : MonoBehaviour
{
    public float theDistance;
        public GameObject DialogKamera;
    public GameObject Spieler;
    public GameObject Dialogback;
    public GameObject TextAlte;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject UiAufgabeNeben;
    public GameObject Schlüssel;
    public GameObject Etaste;
    public GameObject Triggere;
    public GameObject Altee;
    public AudioSource Mumble;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

        if(Etaste.activeSelf && TextAlte.activeSelf && Input.GetKeyDown(KeyCode.E))
        {
        Etaste.SetActive(false);
        Dialogback.SetActive(false);
        TextAlte.SetActive(false);
        UiAufgabeNeben.SetActive(true);
        DialogKamera.SetActive(false);
        Spieler.SetActive(true);
        Schlüssel.SetActive(true);
        Triggere.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        if (theDistance <= 1 && Spieler.activeSelf)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                Mumble.Play();
                StartCoroutine(DialogNPC22());
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
            }
        }
    }

    IEnumerator DialogNPC22()
    {
        Spieler.SetActive(false);
        Altee.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral");
        DialogKamera.SetActive(true);
        Dialogback.SetActive(true);
        TextAlte.SetActive(true);
        yield return new WaitForSeconds(3);
        Etaste.SetActive(true);
    }


    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
