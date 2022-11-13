using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public float a = 5f;
    public float b = 7f;
    public float c = 1f;

    private float result;

    private void Start()
    {
        result = a + b + c; //sum of the 3 previous ones
        Debug.Log(result);
    }
}
