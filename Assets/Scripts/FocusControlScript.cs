using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusControlScript : MonoBehaviour
{
    public GameObject player;
    public GameObject chainRoot;
    public GameObject camera;
    private bool characterControl = true;
    private CameraFollow cameraScript;
    private CharacterControl characterScript;
    private ControlJoint chainRootScript;
    public GameObject playerCamera;
    public GameObject chainCamera;
    // Start is called before the first frame update
    void Start()
    {
        //CameraFollow script;
        cameraScript = (CameraFollow)camera.GetComponent(typeof(CameraFollow));
        characterScript = (CharacterControl)player.GetComponent(typeof(CharacterControl));
        chainRootScript = (ControlJoint)chainRoot.GetComponent(typeof(ControlJoint));
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            if(characterControl) {
                cameraScript.setCurrentTransform(chainCamera.transform);
            } else {
                cameraScript.setCurrentTransform(playerCamera.transform);
            }
            characterControl = !characterControl;
            characterScript.toggleEnabled();
            chainRootScript.toggleEnabled();
        }
    }
}
