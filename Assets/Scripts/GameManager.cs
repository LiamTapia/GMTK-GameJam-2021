using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void EndGame(){
        if(gameHasEnded == false){
            gameHasEnded = true;
            //Restart();
            //GameOverScreen.SetActive(true);
        }
    }

    public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
