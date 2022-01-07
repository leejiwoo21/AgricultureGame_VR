using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class wateringCan : MonoBehaviour
{
    public const float maxCapacity = 100f;
    public const float WaterSpeed = 0.1f;
    public Transform waterPos;
    public ParticleSystem ps;
    private bool psOn = false;
    public float currCapacity = maxCapacity;
    public int maxAngle;
    public int minAngle;

    void Start(){
        ps.Stop();
    }

    void Update()
    {
        if (psOn){
            currCapacity -= WaterSpeed;
            StopWater();
        }
        else SprayWater();
    }

    void OnTriggernEnter(Collider collision)
    {
        if(collision.gameObject.name == "Well")
        {
            currCapacity = 100f;
        }
    }

    void SprayWater(){
        if (transform.rotation.eulerAngles.z > minAngle
            && transform.rotation.eulerAngles.z <= maxAngle
            && currCapacity > 0.0f)
        {
            ps.Play();
            psOn = true;
        }
    }

    void StopWater(){
        if (transform.rotation.eulerAngles.z > maxAngle
            || transform.rotation.eulerAngles.z <= minAngle
            || currCapacity <= 0.0f)
        {
            ps.Stop();
            psOn = false;
        }
    }
}