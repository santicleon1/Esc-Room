using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public GameObject buttonOff;
    public GameObject buttonOn;
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "button")
        {
            buttonOff.SetActive(false);
            buttonOn.SetActive(true);
        }
    }
}
