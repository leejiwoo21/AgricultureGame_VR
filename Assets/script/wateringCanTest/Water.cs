using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    void Start(){
        Destroy(gameObject, 3);
    }
    void OnCollisionEnter(Collision other) {
        Destroy(this.gameObject);
    }
}
