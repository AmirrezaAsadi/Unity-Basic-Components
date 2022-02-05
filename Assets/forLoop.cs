using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forLoop : MonoBehaviour
{
    // Start is called before the first frame update
    int enemies = 5;

    // Update is called once per frame
    void Start()
    {

        for (int i=0; i<enemies; i++)
        {
            Debug.Log("Enemy Unit " + i);
        }
    }
}
