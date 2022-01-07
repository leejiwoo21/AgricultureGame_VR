using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToolsBtn : MonoBehaviour
{
    public enum Type { CIRCLE, RECTANGLE, WATERINGCAN }
    public Type type;

    public int getType() { return (int)type; }
}
