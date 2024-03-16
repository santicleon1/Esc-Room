using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject player;
    public GameObject floor1;
    public GameObject floor2;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            floor1.SetActive(false);
            floor2.SetActive(false);
            Destroy(player.GetComponent<jumping>());
        }
    }
}

