using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    public int personAge = 21;
    public string personName = "Carlos";

    private void Start()
    {
        Debug.Log($"Hello, {personName}! You are {personAge} years old.");
    }
}
