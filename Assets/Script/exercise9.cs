using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise9 : MonoBehaviour
{
    public int candyAvailable = 7;  //candy available
    public int numberOfPeople = 4;  //people

    private void Start()
    {
        candyAvailable %= numberOfPeople;
        Debug.Log(candyAvailable);
    }
}
