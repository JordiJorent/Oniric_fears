using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpscarestrigger : MonoBehaviour
{
    public GameObject maniqui;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            maniqui.SetActive(true);
        }
    }



}