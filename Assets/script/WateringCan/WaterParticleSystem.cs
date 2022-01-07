using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterParticleSystem : MonoBehaviour
{
    public GameObject Seed;
    private void OnParticleCollision(GameObject other) {

        Seed seed = other.GetComponent<Seed>();

        if (seed == null) return;
        Debug.Log("waterd");

        seed.Grown();

    }
}
