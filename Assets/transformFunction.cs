using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformFunction : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    public float turnSpeed = 50.0f;
    public GameObject other;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * -1 * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.RightCommand))
        {
            //Destroy(other);
            //destory (other,delay);
            Destroy(other.GetComponent<MeshRenderer>());
        }

    }
}
