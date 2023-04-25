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
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, raydistance))
            {
                if (hit.transform.gameObject.tag == "linterna")
                {
                    Destroy(hit.transform.gameObject);
                    flashlight.SetActive(true);
                }
            }
        }
    }
}
