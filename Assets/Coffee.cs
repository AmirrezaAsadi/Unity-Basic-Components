using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffee : MonoBehaviour
{
    float coffeeTemprature = 90.0f;
    const float hotLimitDegree= 70.0f;
    const float coldLimitDegree = 45.0f;

    
    

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CheckTemprature();
        }
        coffeeTemprature -= Time.deltaTime * 5.0f;

    }

        void CheckTemprature()
    {

        if (coffeeTemprature > hotLimitDegree)
        {
            Debug.Log("that's too hot");
        }

        else if (coffeeTemprature < coldLimitDegree)
        {
            Debug.Log("I dont like ice coffee");
        }

        else
        {
            Debug.Log(" That the right degree");
        }
    }

}



