using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOrExit : MonoBehaviour
{
    public int SceneId;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneId);
    }
    public void ExitGame()
    {
        Application.Quit(); 
    }
}
