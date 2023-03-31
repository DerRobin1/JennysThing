using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchlusselPickUp : MonoBehaviour
{
    public float theDistance;
    public GameObject actionDisplay;
    public GameObject actionText;
    public GameObject Abge;
    public GameObject Trigger2;
    public AudioSource Klink;
    public GameObject Schlüssel;
    public GameObject Cylinder;
    public GameObject Altee;

    // Update is called once per frame
    void Update()
    {
        theDistance = PlayerCasting.distanceFromTarget;
    }

    void OnMouseOver()
    {
        if (theDistance <= 4)
        {
            actionDisplay.SetActive(true);
            actionText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Klink.Play();
                Abge.SetActive(true);
                Trigger2.SetActive(true);
                Cylinder.SetActive(true);
                Altee.GetComponent<Animator>().Play("CharacterArmature_Wave");
                Schlüssel.SetActive(false);
                actionDisplay.SetActive(false);
                actionText.SetActive(false);
            }
        }
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
