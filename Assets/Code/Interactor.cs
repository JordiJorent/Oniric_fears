using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interactor : MonoBehaviour
{
    public Transform InteractorSource;
    public float InteractRange;
    public GameObject Reticle;
    public GameObject InteractReticle;


    // Start is called before the first frame update
    void Start()
    {
        Reticle.SetActive(true);
        InteractReticle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray r= new Ray(InteractorSource.position, InteractorSource.forward);
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if(hitInfo.transform.gameObject.tag=="television")
                {
                    hitInfo.transform.gameObject.GetComponent<TeleEncindida>().Interactuar();
                    hitInfo.transform.gameObject.GetComponent<TriggerEvents>().CustomEvent();
                }
                else if(hitInfo.transform.gameObject.tag == "door")
                {
                    hitInfo.transform.gameObject.GetComponent<Animator>().SetBool("openDoor", true);
                    hitInfo.transform.gameObject.GetComponent<BoxCollider>().enabled = false;
                }
                
            }
        }
        CheckForInteractor();
    }
    private void CheckForInteractor()
    {
        Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
            if (hitInfo.transform.gameObject.tag == "television" || hitInfo.transform.gameObject.tag=="linterna" || hitInfo.transform.gameObject.tag == "door")
            {
                Reticle.SetActive(false);
                InteractReticle.SetActive(true);
                Debug.DrawRay(InteractorSource.position, InteractorSource.forward, Color.green);
            }
            else
            {
                Reticle.SetActive(true);
                InteractReticle.SetActive(false);
                Debug.DrawRay(InteractorSource.position, InteractorSource.forward, Color.red);

            }
        }
        else
        {
            Reticle.SetActive(true);
            InteractReticle.SetActive(false);
            Debug.DrawRay(InteractorSource.position, InteractorSource.forward, Color.red);
        }
    }
}
