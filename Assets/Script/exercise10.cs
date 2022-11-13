using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise10 : MonoBehaviour
{
    public int x = 2;  //value

    public int a = 1;
    public int b = 2;
    public int c = 3;    //multiples of 2
    public int d = 4;
    public int e = 5;
    public int f = 6;
    public int g = 7;
    public int h = 8;
    public int i = 9;
    public int j = 10;


    private float result;
    private void Start()
    {
        result = x * a;
        Debug.Log(result);

        result = x * b;
        Debug.Log(result);

        result = x * c;
        Debug.Log(result);

        result = x * d;
        Debug.Log(result);

        result = x * e;
        Debug.Log(result);

        result = x * f;
        Debug.Log(result);

        result = x * g;
        Debug.Log(result);

        result = x * h;
        Debug.Log(result);

        result = x * i;
        Debug.Log(result);

        result = x * j;
        Debug.Log(result);

    }
}
