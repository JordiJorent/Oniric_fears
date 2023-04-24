using UnityEngine;

public class Linternaswap : MonoBehaviour
{
    public GameObject flashlight;
    public float raydistance = 200f; 
    public RaycastHit hit;
    public GameObject texto;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        flashlight.SetActive(false);
        Player = GameObject.FindGameObjectWithTag("MainCamera");
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
        if (Player!= null)
        {
            texto.transform.LookAt(Player.transform.position);
        }
    }
}
