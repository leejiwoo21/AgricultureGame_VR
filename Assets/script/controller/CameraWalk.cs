using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWalk : MonoBehaviour
{
    public GameObject TL;
    public GameObject TR;
    public GameObject Cam;
    public Vector3 camPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //camPosition.x = (TL.transform.localPosition.x + TR.transform.localPosition.x) / 2;
        //camPosition.z = (TL.transform.localPosition.z + TR.transform.localPosition.z) / 2;
        camPosition.x = Cam.transform.localPosition.x;
        camPosition.z = Cam.transform.localPosition.z;
        camPosition.y = (TL.transform.localPosition.y + TR.transform.localPosition.y) / 2  + 2;
        Cam.transform.localPosition = camPosition;
    }
}
