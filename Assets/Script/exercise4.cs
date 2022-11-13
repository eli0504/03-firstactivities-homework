using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
    public int yearBirth = 2001;  //person's year birth
    public int currentYear = 2022;  //current year
    public int personAge = 21;  //person’s age

    private void Start()
    {
        Debug.Log($"You were born in {yearBirth} and we are currently in {currentYear}.");
        Debug.Log($"If we are in the year {currentYear} and you were born in {yearBirth}, you are {personAge} years old.");
    }
}
