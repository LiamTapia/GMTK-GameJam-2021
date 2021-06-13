using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalScene : MonoBehaviour
{
    public AudioSource audioSource;
    
    // Start is called before the first frame update
    public void returnToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void playButtonSound()
    {
        audioSource.Play();
    }
}
