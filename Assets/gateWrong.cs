using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateWrong : MonoBehaviour
{
    public GameObject player;
    public GameObject button;
    public GameObject button2;
    public GameObject floorL;
    public GameObject floorR;
    void Update()
    {
        if (button.activeInHierarchy == true)
        {
            floorL.SetActive(false);
            floorR.SetActive(false);
            button.SetActive(false);
            button2.SetActive(false);
            Destroy(player.GetComponent<jumping>());
        }
    }
}