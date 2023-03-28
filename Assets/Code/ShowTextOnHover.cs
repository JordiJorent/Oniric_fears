using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextOnHover : MonoBehaviour
{
    public Canvas hoverText;

    // Start is called before the first frame update
    void Start()
    {
        hoverText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseEnter()
    {
        hoverText.gameObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        hoverText.gameObject.SetActive(false);
    }
}
