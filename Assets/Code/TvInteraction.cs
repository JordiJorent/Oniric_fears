using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvInteraction : MonoBehaviour
{
    public GameObject tv;
    public float raydistance = 200f;
    public RaycastHit hit; 
    // Start is called before the first frame update
    void Start()
    {
        tv.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.forward * raydistance, Color.blue);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("key pressed");
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, raydistance))
            {
                Debug.Log("Raycast impacted");
                if (hit.transform.gameObject.tag == "television")
                {
                    Debug.Log("asd impacted");

                    Destroy(hit.transform.gameObject);
                    tv.SetActive(true);
                }
            }
        }
    }
}
