using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidePhone : MonoBehaviour
{
    public GameObject phone;
    // Start is called before the first frame update
    void Start()
    {
        phone.SetActive(false);
        Invoke("show", 60);
    }

    void show()
    {
        phone.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
