using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereaMove : MonoBehaviour
{
    private float xRotae = 0.01f;
    public float turnSpeed = 4.0f;
    public float moveSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        MouseRotation();
        KeyboardMove();
    }

    public void MouseRotation(){
        float yRotateSize = Input.GetAxis("Mouse X") * turnSpeed;
        float yRotate = transform.eulerAngles.y + yRotateSize;

        float xRotateSize = -Input.GetAxis("Mouse Y") * turnSpeed;
        xRotae = Mathf.Clamp(xRotae + xRotateSize, -45, 80);

        transform.eulerAngles = new Vector3(xRotae, yRotate, 0);
    }

    void KeyboardMove(){
        Vector3 dir = new Vector3(
            Input.GetAxis("Horizontal"),
            0,
            Input.GetAxis("Vertical")
        );
        transform.Translate(dir * moveSpeed * Time.deltaTime);
    }
}
