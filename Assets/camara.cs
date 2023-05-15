using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;  
public class camara : MonoBehaviour
{
    
    private Transform Player;
    private Rigidbody rb;
    private Quaternion lastQuat;
    [SerializeField] private float minDistanceBtwnPlayerAndCamera = 2.3f;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            if (Vector3.Distance(transform.position, Player.position) < minDistanceBtwnPlayerAndCamera)
            {
                transform.rotation = lastQuat;
            }
            else
            {
                transform.LookAt(Player.position);
                lastQuat = transform.rotation;
            }

        }
    }
}
