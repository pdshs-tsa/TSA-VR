using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{
    public string nextScene;

    public void LoadScene()
    {
        SceneManager.LoadScene(nextScene);
    }
}
