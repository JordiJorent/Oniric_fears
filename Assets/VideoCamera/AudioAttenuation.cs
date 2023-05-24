using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAttenuation : MonoBehaviour
{
    public Transform player;
    private AudioSource src;
    private float initialPitch;
    private float increasedBassPitch;
    public float ammountToDecrasePitch;
    public float ammountToDecraseVolume;
    private float initVolume;
    private float decreasedVolume;
    private void Awake()
    {
        src = GetComponent<AudioSource>();
        initialPitch = src.pitch;
        increasedBassPitch = initialPitch / ammountToDecrasePitch;
        initVolume = src.volume;
        decreasedVolume = initVolume / ammountToDecraseVolume;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(RaycastToPlayer())
        {
            src.volume = Mathf.Lerp(src.volume, initVolume, 0.15f);
            src.pitch = Mathf.Lerp(src.pitch, initialPitch, 0.15f);
        }
        else
        {
            src.volume = Mathf.Lerp(src.volume, decreasedVolume, 0.15f);
            src.pitch = Mathf.Lerp(src.volume, increasedBassPitch, 0.15f);
        }
        decreasedVolume = initVolume / ammountToDecraseVolume;
        increasedBassPitch = initialPitch / ammountToDecrasePitch;
    }
    bool RaycastToPlayer()
    {
        bool ret;
        RaycastHit hit;
        if (Physics.Raycast(transform.position, player.position - transform.position, out hit, Vector3.Distance(transform.position, player.position)))
        {
            if(hit.transform.gameObject.CompareTag("Player"))
            {
                ret = true;
                Debug.DrawRay(transform.position, (player.position - transform.position) * 100f, Color.green);
            }
            else
            {
                ret = false;
                Debug.DrawRay(transform.position, (player.position - transform.position) * 100f, Color.blue);
            }
        }
        else
        {
            ret = false;
            Debug.DrawRay(transform.position, (player.position - transform.position) * 100f, Color.blue);
        }
        
        return ret;
    }
}
