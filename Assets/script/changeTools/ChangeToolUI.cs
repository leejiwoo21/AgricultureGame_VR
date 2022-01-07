using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.EventSystems;

public class ChangeToolUI : MonoBehaviour
{
    public SteamVR_Action_Boolean btn;
    public GameObject[] tools;
    private int currIdx = 0;
    public GameObject changeUI;
    public GameObject pointer;
    public GameObject CameraRig;
    private bool menuOn = false;

    private void Start()
    {
        pointer.SetActive(menuOn);
        changeUI.SetActive(menuOn);
        tools[0].SetActive(true);
        for (int i = 1; i < tools.Length; i++)
        {
            tools[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (btn.GetStateDown(SteamVR_Input_Sources.LeftHand) && menuOn == false)
        {
            menuOn = true;
            pointer.SetActive(menuOn);
            changeUI.SetActive(menuOn);
        }
    }

    public void onClickToolBtn()
    {
        tools[currIdx].SetActive(false);
        GameObject currBtn = EventSystem.current.currentSelectedGameObject;
        currIdx = currBtn.GetComponent<ChangeToolsBtn>().getType();
        Debug.Log(currIdx);
        tools[currIdx].SetActive(true);

        menuOn = false;
        pointer.SetActive(menuOn);
        changeUI.SetActive(menuOn);
    }
}
