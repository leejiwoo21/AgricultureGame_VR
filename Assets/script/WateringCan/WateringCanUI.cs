using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using UnityEngine.UI;

public class WateringCanUI : MonoBehaviour
{
    private Text text;
    public wateringCan can;
    public Camera camera;

    void Start(){
        text = GetComponentInChildren<Text>();
        can = GetComponentInParent<wateringCan>();
    }

    void Update(){
        text.text = string.Format("{0}", (int)can.currCapacity);
        transform.LookAt(camera.transform);
    }
}
