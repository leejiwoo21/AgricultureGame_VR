using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : MonoBehaviour
{
    public GameObject player;

    MeshRenderer mesh;
    Material mat;
    
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "water")
        {
            mat.color = new Color(0, 0, 0);
            player.GetComponent<Player>().score++;
        }
    }
}
