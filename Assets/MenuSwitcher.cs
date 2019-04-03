using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSwitcher : MonoBehaviour
{
    public GameObject MainMenuCanvas;
    public GameObject CornerButton;
    private bool trigger = true;

    void Start() {
        MainMenuCanvas = this.gameObject.transform.GetChild(0).gameObject;

        CornerButton = this.gameObject.transform.GetChild(1).gameObject;
        string name1 = MainMenuCanvas.transform.name;
        string name2 = CornerButton.transform.name;
        Debug.Log("Main Menu Canvas: " + name1 + "\n Button Canvas: " + name2);

        MainMenuCanvas.SetActive(trigger);
        CornerButton.SetActive(!trigger);
    }


 
}
