using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise6 : MonoBehaviour
{
    public int day = 5; //day of the week

    public void Start()
    {
        if (day > 0)
        {
            Debug.Log($"Day {day} does not belong to the weekend");
        }
    }
}
