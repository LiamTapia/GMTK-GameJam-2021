using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawScript : MonoBehaviour
{
    public Transform transform1;
    public Transform transform2;
    private bool onInitialPosition = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onInitialPosition) {
            if(Vector3.Distance(transform.position, transform1.position) > 0.05) {
                transform.position = Vector3.Lerp(transform.position, transform1.position, Time.deltaTime * 2);
            }
        } else {
            if(Vector3.Distance(transform.position, transform2.position) > 0.05) {
                transform.position = Vector3.Lerp(transform.position, transform2.position, Time.deltaTime * 2);
            }
        }
    }

    public void toggle() {
        onInitialPosition = !onInitialPosition;
    }
}
