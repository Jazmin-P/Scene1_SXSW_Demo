using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeQuestion : MonoBehaviour
{
    public Image original;
    public Sprite newSprite;
    public Sprite otherSprite;
    public int count;
    public GameObject phone;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewImage()
    {
        if (count == 0){
            original.sprite = newSprite;
            count = count + 1;
        }
        else if(count == 1)
        {
            original.sprite = otherSprite;
            count += 1;
        }
        else if (count == 2)
        {
            phone.gameObject.SetActive(false);
        }
    }
}
