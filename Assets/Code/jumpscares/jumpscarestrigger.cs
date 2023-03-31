using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscarestrigger : MonoBehaviour
{
    public GameObject maniqui;
    public bool isactive = true;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isactive = true;
        }
    }
}
