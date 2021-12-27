using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Polygon : MonoBehaviour
{
   public enum Type{CIRCLE, RECTANGLE, CYLINDER}
   public Type type;

   public int getType(){return (int)type;}
}
