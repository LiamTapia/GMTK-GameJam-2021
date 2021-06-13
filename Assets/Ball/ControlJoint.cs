using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJoint : MonoBehaviour
{
    public float speed = 2.0f;
    private bool enabled;
    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(enabled) {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical   = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;
            transform.Translate(direction * Time.deltaTime * speed);
            /*
            if(Input.GetKey("i"))
            {
                transform.Translate(Vector3.forward * Time.deltaTime * speed);
            }
            else if(Input.GetKey("k"))
            {
                transform.Translate(Vector3.back * Time.deltaTime * speed);
            }
            if(Input.GetKey("j"))
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
            else if(Input.GetKey("l"))
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
            if(Input.GetKey("o")) {
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
            else if(Input.GetKey("p")) {
                transform.Translate(Vector3.down * Time.deltaTime * speed);
            }
            */
        }
    }

    public void toggleEnabled() {
        enabled = !enabled;
    }
}
