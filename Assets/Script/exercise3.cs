using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    public int personAge = 21;  //person’s age
    public string personName = "Carlos";  //person’s name

    private void Start()
    {
        Debug.Log($"Hello, {personName}! You are {personAge} years old.");
    }
}
