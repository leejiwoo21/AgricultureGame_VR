using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wateringCan : MonoBehaviour
{
    public const float MaxCapacity = 100f;
    public const float WaterSpeed = 0.01f;
    public Transform waterPos;
    public float moveSpeed = 0.50f;
    public float rotateSpeed = 0.5f;
    public ParticleSystem ps;
    private bool psOn = false;
    public float currCapacity = MaxCapacity;

    void Start(){
        ps.Stop();
    }

    void Update()
    {
        KeyboardMove();
        KeyboardRotate();
        if(psOn){
            currCapacity -= WaterSpeed;
            StopWater();
        }
        else SprayWater();
    }
    
    void KeyboardMove(){
        Vector3 dir = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );
        transform.Translate(dir * moveSpeed * Time.deltaTime);
    }

    void KeyboardRotate(){
        Vector3 currAngles = transform.rotation.eulerAngles;
        if(Input.GetKey(KeyCode.Q)){
            currAngles.z += rotateSpeed;
        }
        if(Input.GetKey(KeyCode.E)){
            currAngles.z -= rotateSpeed;
        }
        currAngles.z = Mathf.Clamp(currAngles.z, 0, 60);
        transform.eulerAngles = currAngles;
    }

    void SprayWater(){
        if(transform.rotation.eulerAngles.z > 55
            && currCapacity > 0.0f)
        {
            ps.Play();
            psOn = true;
        }
    }

    void StopWater(){
        if(transform.rotation.eulerAngles.z < 55
            || currCapacity <= 0.0f)
        {
            ps.Stop();
            psOn = false;
        }
    }
}