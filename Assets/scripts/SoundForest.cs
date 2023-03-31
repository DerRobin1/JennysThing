using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundForest : MonoBehaviour
{

    public GameObject SoundGut;
    public GameObject SoundBirds;
    public GameObject SoundCreep;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundGut.SetActive(false);
            SoundBirds.SetActive(false);
            SoundCreep.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundGut.SetActive(true);
            SoundBirds.SetActive(true);
            SoundCreep.SetActive(false);
        }
    }
}
