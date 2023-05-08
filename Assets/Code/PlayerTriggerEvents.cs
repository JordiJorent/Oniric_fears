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
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Ascensor Trigger")
        {
            anim.SetBool("DoorHolder", false);
            
        }
        else if (other.gameObject.name == "FinalTrigger")
        {
            anim.SetBool("DoorHolder", false);
        }
    }
}
