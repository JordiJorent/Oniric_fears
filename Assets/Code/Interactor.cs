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
                
            }
        }
        CheckForInteractor();
    }
    private void CheckForInteractor()
    {
        Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
        {
            if (hitInfo.transform.gameObject.tag == "television" || hitInfo.transform.gameObject.tag=="linterna")
            {
                Reticle.SetActive(false);
                InteractReticle.SetActive(true);
            }
            else
            {
                Reticle.SetActive(true);
                InteractReticle.SetActive(false);
            }
        }
        else
        {
            Reticle.SetActive(true);
            InteractReticle.SetActive(false);
        }
    }
}
