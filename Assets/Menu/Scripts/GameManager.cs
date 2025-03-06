using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject chooseDrinkText;
    public GameObject chooseNotFoodText;
    public GameObject[] menuItems;

    private GameObject itemChosen;
    private GameObject foodChosen;
    private GameObject itemForDate;
    public bool isFirstRound = true;
    public bool isForDate = false;

    public GameObject UICanvas;
    public InputActionProperty showButtonLeft;
    public InputActionProperty showButtonRight;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (showButtonLeft.action.WasPressedThisFrame() || showButtonRight.action.WasPressedThisFrame())
        {
            UICanvas.SetActive(!UICanvas.activeSelf);
        }
    }

    public void ShowObject(int index)
    {
        //if first round and orders a drink
        if (isFirstRound && index <= 5)
        {
            itemChosen = Instantiate(menuItems[index]);

            //date mirrors the users choise
            itemForDate = Instantiate(menuItems[index], new Vector3(3.26f, 0.74f, 7.04f), transform.rotation);
            isFirstRound = false;
        }
        //if orders food
        else if ((isFirstRound && index >= 6 && !isForDate) || (!isFirstRound && index >= 6 && !isForDate))
        {
            if(foodChosen != null)
            {
                Destroy(foodChosen);
            }
            foodChosen = Instantiate(menuItems[index]);
        }
        //if not first round and orders a drink
        else if (!isFirstRound)
        {
            if (!isForDate){
                if(itemChosen != null)
                {
                    Destroy(itemChosen);
                }
                itemChosen = Instantiate(menuItems[index]);
                chooseDrinkText.gameObject.SetActive(true);
                isForDate = true;
            }
            else
            {
                //if chose food for date
                if(index >= 6)
                {
                    chooseDrinkText.gameObject.SetActive(false);
                    chooseNotFoodText.gameObject.SetActive(true);
                }
                else
                {
                    if (chooseNotFoodText.gameObject.activeInHierarchy)
                    {
                        chooseNotFoodText.gameObject.SetActive(false);
                    }
                    if(itemForDate != null)
                    {
                        Destroy(itemForDate);
                    }
                    itemForDate = Instantiate(menuItems[index], new Vector3(3.26f, 0.74f, 7.04f), transform.rotation);
                    chooseDrinkText.gameObject.SetActive(false);
                    isForDate = false;
                }
            }
        } 
    }
}
