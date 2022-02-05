using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMouse : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {

        rb = GetComponent<Rigidbody>();
        GetComponent<Renderer>().material.color = Color.red; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        rb.AddForce(-transform.forward * 500f);
        rb.useGravity = true;
    }
}
