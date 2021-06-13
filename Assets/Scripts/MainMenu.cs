using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainVisual;
    public GameObject Credits;
    public GameObject Text;
    public string firstLevel;
    public AudioSource audioSource;

    public void activateCredits(bool option)
    {
        mainVisual.SetActive(option);
        Credits.SetActive(!option);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void activateLore(bool option)
    {
        mainVisual.SetActive(option);
        Text.SetActive(!option);
    }

    public void BeginGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void playButtonSound()
    {
        audioSource.Play();
    }
}
