using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllesGesammelt : MonoBehaviour
{
    public GameObject Cylinder;
    public GameObject Witcher;
    public GameObject UiAufgabeNEU;
    public GameObject UiAufgabe;

    // Start is called before the first frame update
    void Start()
    {
        Cylinder.SetActive(true);
        Witcher.SetActive(true);
        UiAufgabeNEU.SetActive(true);
        UiAufgabe.SetActive(false);
    }

}
