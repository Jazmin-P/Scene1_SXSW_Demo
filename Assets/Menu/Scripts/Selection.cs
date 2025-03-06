using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    private Button button;
    public int selectInt;
    private GameManager gameManager;


    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetOption);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetOption()
    {
        Debug.Log(gameObject.name + " was selected");
        gameManager.ShowObject(selectInt);
    }
}
