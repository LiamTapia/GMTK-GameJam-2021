using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPosition = player.transform.position + cameraOffset;
        //transform.position = newPosition;
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, Time.deltaTime * 4);
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime * 2);
    }

    public void setCurrentTransform(Transform transform) {
        target = transform;
    }
}
