using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VideoCamera : MonoBehaviour
{
    public GameObject secondPos;
    public GameObject firstPos;
    private bool isInSecondPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            isInSecondPos = !isInSecondPos;
        }
        if(!isInSecondPos)
        {
            firstPos.SetActive(true);
            secondPos.SetActive(false);
        }
        else
        {
            firstPos.SetActive(false);
            secondPos.SetActive(true);
        }
    }
}
