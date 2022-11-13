using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise8 : MonoBehaviour
{
    public string month = "july";  //name of a month

    private void Start()
    {
        if (month == "january" || month == "march" || month == "may" || month == "july" || month == "august" || month == "october" || month == "december")
        {
            Debug.Log($"The month {month} has 31 days");
        }
        else if (month == "february")  /*
                                        There is more than one option
                                     */
        {
            Debug.Log($"The {month} has 28 days");
        }
        else   /*
                is none of the above
              */
        {
            Debug.Log($"The month {month} has 30 days");
        }
}
}

