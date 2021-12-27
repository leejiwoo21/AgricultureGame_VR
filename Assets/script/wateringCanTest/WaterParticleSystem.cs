using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterParticleSystem : MonoBehaviour
{
    private void OnParticleCollision(GameObject other) {
        Plane plane = other.GetComponent<Plane>();
        
        if(plane == null) return;
        plane.ConsumeWater();
    }
}
