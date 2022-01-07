using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Resumebtn : MonoBehaviour
{

    public GameObject ui;
    public GameObject Cube;
    public bool menuOn;
    public void OnClickButton()
    {
        menuOn = Cube.GetComponent<UI_Generate>().menuOn;
        ui.SetActive(false);
        menuOn = false;
        Debug.Log("Clicked@");

    }
}
