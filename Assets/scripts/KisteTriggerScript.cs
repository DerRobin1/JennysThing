using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KisteTriggerScript : MonoBehaviour
{
    public float theDistance;
    public GameObject Kiste;
    public GameObject Licht;
    public GameObject Trigger;
    public GameObject actionText;
    public GameObject actionDisplay;
    public AudioSource Klappeauf;
    public GameObject Fade;
    public AudioSource PraySound;


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
                StartCoroutine(KisteAufmachen());
            }
        }
    }

    IEnumerator KisteAufmachen()
    {
        Kiste.GetComponent<Animator>().Play("Lid");
        Klappeauf.Play();
        yield return new WaitForSeconds(1);
        Licht.SetActive(true);
        PraySound.Play();
        yield return new WaitForSeconds(1);
        Fade.SetActive(true);
        yield return new WaitForSeconds(1);
        Trigger.GetComponent<BoxCollider>().enabled = false;
        SceneManager.LoadScene("Ende");
    }

    void OnMouseExit()
    {
        actionDisplay.SetActive(false);
        actionText.SetActive(false);
    }

}
