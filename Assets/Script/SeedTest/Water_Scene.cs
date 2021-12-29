using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water_Scene : MonoBehaviour
{
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}