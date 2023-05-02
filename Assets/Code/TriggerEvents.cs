using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86.Avx;

public class TriggerEvents : MonoBehaviour
{
    public GameObject AllLights;
    public AcensorCierre tmp; 
    // Start is called before the first frame update
    void Start()
    {
        AllLights = GameObject.Find("Light");
        tmp = GameObject.Find("Ascensor Trigger").GetComponent<AcensorCierre>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CustomEvent()
    {
        switch (gameObject.name)
        {
            //case "ApagarLuz":
            //   // TurnOfLights();
            //    tmp.activeTriggers++;
            //    break;
            //case "EncenderLuz":
            //   // TurnOnLights();
            //    tmp.activeTriggers++;
            //    break;
            default:

                tmp.activeTriggers++;
                gameObject.tag = "Untagged";
                Debug.Log("PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAIIIIIIIIIIIIIIIIIIIIIIIIIIIIITTTTTTTTTTTTTTTTTTTT" + tmp.activeTriggers);
                break;
        }
    }
    //public void TurnOfLights()
    //{
    //    AllLights.SetActive(false);
    //}
    //public void TurnOnLights()
    //{
    //    AllLights.SetActive(true);
    //}
    
}
