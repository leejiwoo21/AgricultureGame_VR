using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public const int maxCapacity = 100;
    public const int oneWater = 1;
    public int waterCapacity = 0;
    public ParticleSystem ps;
    /*
    private void OnParticleCollision(GameObject other) {
        if(other.gameObject.CompareTag("Water")){
            gameObject.GetComponent<MeshRenderer>()
                        .material.color = Color.blue;
            Debug.Log("흡수2");
        }
    }
    */

    private void Update(){
        if(waterCapacity >= maxCapacity)
            gameObject.GetComponent<MeshRenderer>()
                        .material.color = Color.blue;
    }

    public void ConsumeWater(){
        Debug.Log("흡수");
        waterCapacity += oneWater;
    }
}
