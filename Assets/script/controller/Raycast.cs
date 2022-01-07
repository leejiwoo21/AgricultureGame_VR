using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast
{
    public static int GetClickPolygon()
    {
        if(Input.GetMouseButton(0)){
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            
            if(Physics.Raycast(ray, out hit)){
                Debug.Log(hit.transform.gameObject.name);
                Polygon polygon = hit.transform.gameObject.GetComponent<Polygon>();
                Debug.Log(polygon.getType());
                return polygon.getType();
            }
        }
        return -1;
    }
}
