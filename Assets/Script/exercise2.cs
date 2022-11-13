using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour
{
    public string personName = "Carlos";  //person's name
    public string cityName = "Madrid";  //city's name

    private void Start()
    {
        Debug.Log($"Hello, {personName}! Welcome to {cityName}. ");
    }

}
