using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class KrystalPickUp : MonoBehaviour
{
    public AudioSource Einsammel;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Einsammel.Play();
            GlobalKristalCount.CurrentKry += 1;
            this.gameObject.SetActive(false);
        }
    }
}
