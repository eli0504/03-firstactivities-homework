using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise7 : MonoBehaviour
{
    public string letter = "u";

    private void Start()
    {
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            Debug.Log("The letter is a vowel");
        }
        else    /*
                    if it's not a vowel, it's a consonant
               */
        {
            Debug.Log("The letter is a consonant");  
        }
    }

}
