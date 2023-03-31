using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTalk : MonoBehaviour
{
    public float theDistance;
    public GameObject Sprechblase;
    public GameObject actionDisplay;
    public GameObject actionText;
    public AudioSource WasWirdGesagt;
    public GameObject Trigger;

    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 1)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(DialogNPC());
            }
        }
    }

    IEnumerator DialogNPC()
    {
        Sprechblase.SetActive(false);
        Trigger.GetComponent<BoxCollider>().enabled = false;
        WasWirdGesagt.Play();
        yield return new WaitForSeconds(8);
        Trigger.GetComponent<BoxCollider>().enabled = true;

    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
