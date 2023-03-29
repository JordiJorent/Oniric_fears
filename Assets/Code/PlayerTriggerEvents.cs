using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggerEvents : MonoBehaviour
{
    public Animator anim;
    public GameObject FinalTrigger;
    // Start is called before the first frame update
    void Start()
    {
        FinalTrigger.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ascensor Trigger")
        {
            anim.SetBool("openDoor", false);
            FinalTrigger.SetActive(true);
        }
        else if (other.gameObject.name == "FinalTrigger")
        {
            anim.SetBool("openDoor", false);
        }
    }
}
