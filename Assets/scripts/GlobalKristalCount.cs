using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalKristalCount : MonoBehaviour
{
    public static int CurrentKry;
    public int InternalKry;
    public GameObject KryDisplay;
    public GameObject TriggerJa;

    // Update is called once per frame
    void Update()
    {
        InternalKry = CurrentKry;
        KryDisplay.GetComponent<Text>().text = "" + InternalKry;

                if (CurrentKry == 10)
        {
            TriggerJa.SetActive(true);
        }
    }
}
