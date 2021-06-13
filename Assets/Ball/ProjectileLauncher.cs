using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform muzzlePoint;
    public float timeBetweenFire = 1.5f;
    private float timeStamp = 0;
    // Start is called before the first frame update
    void Start()
    {
        timeStamp = Time.time + timeBetweenFire;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeStamp) {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, muzzlePoint.position, muzzlePoint.rotation) as Rigidbody;
            projectileInstance.AddForce(muzzlePoint.forward * 350f);
            timeStamp = Time.time + timeBetweenFire;
            SoundManagerScript.PlaySound("shooting");
        }
    }
}
