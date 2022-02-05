using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileLoop : MonoBehaviour
{
    // Start is called before the first frame update
    bool continueLoop = true;

    // Update is called once per frame
    void Update()
    {

        while (continueLoop)
        {
            Debug.Log("Loop has played");
            continueLoop = false;
        }
    }
}
