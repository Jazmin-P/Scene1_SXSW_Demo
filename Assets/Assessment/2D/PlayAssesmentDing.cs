using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAssesmentDing : MonoBehaviour
{
    private AudioSource dingAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        dingAudioSource = GetComponent<AudioSource>();
        Invoke("PlayAudio", 60);

    }

    public void PlayAudio()
    {
        dingAudioSource.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
