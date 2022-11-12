using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false; 
    public float RestartDelay = 1f;
    public GameObject LevelCompleteUI;
    
    public void LevelCompleted()
    {
        LevelCompleteUI.SetActive(true);
    }
    public void EndGame()
    {
        if(GameHasEnded==false)
        {
            GameHasEnded=true;
            Debug.Log("Game Over");
            Invoke("Restart", RestartDelay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
