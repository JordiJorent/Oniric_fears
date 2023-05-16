using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorTMP : MonoBehaviour
{
    public TriggerEvents tmp;


    // Start is called before the first frame update
    void Start()
    {
        tmp = GameObject.Find("Ascensor Trigger").GetComponent<TriggerEvents>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CustomEvent()
    {
        switch (gameObject.name)
        {
            default:

                tmp.activeTriggers++;
                gameObject.tag = "Untagged";

                break;
        }
    }
}
