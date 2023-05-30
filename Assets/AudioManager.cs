using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    AudioSource audio;
    public List<AudioClip> clips = new List<AudioClip>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        audio = GetComponent<AudioSource>();
    }

    public void PlaySFX(string audioName)
    {
        for (int i = 0; i < clips.Count; i++)
        {
            if (clips[i].name == audioName)
            {
                audio.PlayOneShot(clips[i]);
                return;
            }
        }
    }
}
