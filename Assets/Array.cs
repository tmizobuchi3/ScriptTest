using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    


int i;

    // Start is called before the first frame update
    void Start()
    {
        int[] array = new int[5];

        array[0] = 11;
        array[1] = 12;
        array[2] = 13;
        array[3] = 14;
        array[4] = 15;

        for (i = 0; i < 5; ++i)

        {
            Debug.Log(array[i]);
        }

        for (i = 4; i > -1; --i)

        {
            Debug.Log(array[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
