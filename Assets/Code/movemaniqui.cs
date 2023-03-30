using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movemaniqui : MonoBehaviour
{
    public float time;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (time > 0)
        {
            time -= Time.deltaTime;

        }
        else
        {

            Destroy(this.gameObject);

        }
        transform.position += transform.forward * speed *Time.deltaTime;


        
    }
}
