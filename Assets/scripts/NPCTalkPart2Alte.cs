using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalkPart2Alte : MonoBehaviour
{
    public float theDistance;
    public GameObject DialogKamera;
    public GameObject Spieler;
    public GameObject Dialogback;
    public GameObject TextAlte2;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject UiAufgabeNeben;
    public GameObject Etaste;
    public GameObject Triggere;
    public GameObject Bottle;
    public GameObject Cylinder;
    public GameObject Altee;
    public AudioSource Mumble;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;

        if(Etaste.activeSelf && TextAlte2.activeSelf && Input.GetKeyDown(KeyCode.E))
        {    
        Etaste.SetActive(false);
        Dialogback.SetActive(false);
        TextAlte2.SetActive(false);
        UiAufgabeNeben.SetActive(false);
        DialogKamera.SetActive(false);
        Spieler.SetActive(true);
        Bottle.SetActive(true);
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
                StartCoroutine(DialogNPC23());
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
            }
        }
    }

    IEnumerator DialogNPC23()
    {
        Altee.GetComponent<Animator>().Play("CharacterArmature_Idle_Neutral");
        Cylinder.SetActive(false);
        Spieler.SetActive(false);
        DialogKamera.SetActive(true);
        Dialogback.SetActive(true);
        TextAlte2.SetActive(true);
        yield return new WaitForSeconds(3);
        Etaste.SetActive(true);
    }


    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
