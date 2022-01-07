using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class btnUI : MonoBehaviour
{
    public SteamVR_TrackedObject mto = null;
    public SteamVR_Action_Boolean btn;
    public GameObject uitest;
    public bool menuOn;
    public GameObject Pointer;
    public GameObject CameraRig;

    private void Awake()
    {
        mto = GetComponent<SteamVR_TrackedObject>();
    }

    void Start()
    {
        Pointer.SetActive(false);
        menuOn = false;
        uitest.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (btn.GetStateDown(SteamVR_Input_Sources.LeftHand) && menuOn == false)
        {
            uitest.SetActive(true);
            menuOn = true;
            Pointer.SetActive(true);;
        }
    }
    //UI버튼 제어
    public void onClickResumeBtn()
    {
        menuOn = false;
        uitest.SetActive(false);
        Pointer.SetActive(false);
    }

    public void onClickQuitBtn()
    {
        Application.Quit();
    }

    public void onClickSpaceshipBtn()
    {
        CameraRig.transform.position= Vector3.zero;
        menuOn = false;
        uitest.SetActive(false);
        Pointer.SetActive(false);
    }

}
