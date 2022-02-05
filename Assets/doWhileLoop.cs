using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doWhileLoop : MonoBehaviour
{

    bool continueFlag = false;
    // Update is called once per frame
    void Update()
    {

        do
        {
            Debug.Log("entered do loop ");
        } while (continueFlag==true);
    }
}
