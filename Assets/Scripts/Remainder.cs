using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remainder : MonoBehaviour
{
    float time;

    void Update()
    {
        time =  Mathf.Floor(Time.fixedTime);
        float timeResult = time % 4;

        if (timeResult == 3)
        {
            transform.position = new Vector3(1, 0, 0);
        }
        else if (timeResult == 2)
        {
            transform.position = new Vector3(2, 0, 0);
        }
        else if (timeResult == 1)
        {
            transform.position = new Vector3(3, 0, 0);
        }
        else
        {
            transform.position = new Vector3(4, 0, 0);
        }

    }
}
