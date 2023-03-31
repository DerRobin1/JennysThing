using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turoffnen : MonoBehaviour
{
    public GameObject Tur;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
         Tur.GetComponent<Animator>().Play("Auf");
        }
    }

        void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
         Tur.GetComponent<Animator>().Play("Zu");
        }
    }
}
