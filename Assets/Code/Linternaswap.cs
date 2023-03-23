using UnityEngine;

public class Linternaswap : MonoBehaviour
{
    public GameObject flashlight;
    public float raydistance = 200f; 
    public RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.forward* raydistance, Color.blue);
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("key pressed");
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, raydistance))
            {
                Debug.Log("Raycast impacted");
                if (hit.transform.gameObject.tag == "linterna")
                {
                    Debug.Log("asd impacted");
                    
                    Destroy(hit.transform.gameObject);
                    flashlight.SetActive(true);
                }
            }
        }
    }
}
