using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prompt_scene : MonoBehaviour
{
    public void StartGame()
    {
        Debug.Log("AHAH");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
