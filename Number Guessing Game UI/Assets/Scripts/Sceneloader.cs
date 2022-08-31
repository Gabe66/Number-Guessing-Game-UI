using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneloader : MonoBehaviour
{
    pubic void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildindex;
        SceneManager.LoaderScene(currentSceneIndex + 1);
    }

    public void LoadStartScene()
    {
        SceneManager,LoadScene(0);
    }

    public void QuitGame()
    {
        Application.Quit(); 
    }
        
    



}
