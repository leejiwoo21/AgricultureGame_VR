using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeObject : MonoBehaviour
{
    private int currIdx;
    public GameObject[] objects;
    
    void Start(){
        currIdx = 0;
        objects[0].SetActive(true);
        for(int i = 1; i < objects.Length; i++){
            objects[i].SetActive(false);
        }
    }
    void Update(){
        Swap();
    }
    
    private void Swap(){
        if(Input.GetMouseButton(0)){
            objects[currIdx].SetActive(false);
            currIdx = Raycast.GetClickPolygon();
            objects[currIdx].SetActive(true);
        }
    }
}
