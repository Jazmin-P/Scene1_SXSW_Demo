using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartAudio : MonoBehaviour
{
    public int delay;
    public AudioSource audio;
    public bool clicked;
    public Button button;
    public int time;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        button.onClick.AddListener(StartTimer);
    }

    IEnumerator CountSeconds()
    {
        while (clicked)
        {
            yield return new WaitForSeconds(delay);
            PlayAudio();
        }
    }

    void StartTimer()
    {
        clicked = true;
        StartCoroutine(CountSeconds());
    }

    void PlayAudio()
    {
        clicked = false;
        audio.Play();
    }
}
