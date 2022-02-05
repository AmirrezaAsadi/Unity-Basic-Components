using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forEachLoop : MonoBehaviour
  
{
    string[] enemyNames = { "Div", "xi", "Vladimir" };

    // Start is called before the first frame update

    void Start()
    {
        foreach (string enemy in enemyNames)
        {
            Debug.Log(enemy);
        }

    }

    // Update is called once per frame

    private void Update()
    {
       

    }

}
