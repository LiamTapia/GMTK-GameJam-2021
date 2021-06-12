using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJoint : MonoBehaviour
{
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if(Input.GetKey("s"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if(Input.GetKey("a"))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if(Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}