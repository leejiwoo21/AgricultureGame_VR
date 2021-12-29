using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public bool success = false;
    public int score = 0;
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();

    }


    void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        rigid.AddForce(vec, ForceMode.Impulse);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "spring")
        {
            if(score >= 0)
            {
                SceneManager.LoadScene("spring");
            }
        }
        if (other.gameObject.name == "summer")
        {
            if (score >= 0)
            {
                SceneManager.LoadScene("summer");
            }
        }
        if (other.gameObject.name == "fall")
        {
            if (score >= 0)
            {
                SceneManager.LoadScene("fall");
            }
        }
        if (other.gameObject.name == "winter")
        {
            if (score >= 0)
            {
                SceneManager.LoadScene("winter");
            }
        }
    }
}
