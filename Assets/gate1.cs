using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate1 : MonoBehaviour
{
    public GameObject button;
    public GameObject gateL;
    public GameObject gateR;
    void Update()
    {
        if (button.activeInHierarchy == true)
        {
            gateL.SetActive(false);
            gateR.SetActive(false);
        }
    }
}
