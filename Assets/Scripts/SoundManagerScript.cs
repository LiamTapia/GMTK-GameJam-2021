using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip steps, victory, lose, shooting, drop;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        steps = Resources.Load<AudioClip> ("step");
        victory = Resources.Load<AudioClip> ("victory");
        lose = Resources.Load<AudioClip> ("losing");
        shooting = Resources.Load<AudioClip> ("shoot");
        drop = Resources.Load<AudioClip> ("drops");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound(string clip){
        switch(clip){
            case "step":
                audioSource.PlayOneShot(steps);
                break;
            case "victory":
                audioSource.PlayOneShot(victory);
                break;
            case "lose":
                audioSource.PlayOneShot(lose);
                break;
            case "shooting":
                audioSource.PlayOneShot(shooting);
                break;
            case "drop":
                audioSource.PlayOneShot(drop);
                break;
        }
    }
}
