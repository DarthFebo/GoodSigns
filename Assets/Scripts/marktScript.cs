using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marktScript : MonoBehaviour
{
    public bool inRange = false;
    public GameObject menu;


    void Start()
    {
        inRange = false;
    }

    void OnTriggerEnter(Collider other)
    {
        menu.SetActive(true);
        inRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        menu.SetActive(false);
        inRange = false;
    }
}

