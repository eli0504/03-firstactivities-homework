using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public string personName = "Carlos";
    public string cityName = "Madrid";

    private void Start()
    {
        Debug.Log($"Hello, {personName}! Welcome to {cityName}. ");
    }

}
