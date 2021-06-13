using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public SawScript saw;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("wow");
        Debug.Log(other.gameObject.tag);
        if(other.gameObject.tag == "ball") {
            saw.toggle();
        }
    }
}
