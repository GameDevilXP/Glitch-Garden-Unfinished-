using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] int waitTime = 2;
    int currentSceneIndex;

    private void Start()
    {
        // Getting the buildIndex
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //checking the scene index for loading to the next scene.
        if (currentSceneIndex == 0)
            StartCoroutine(WaitForTime());
    }

    // Wait for the waitTime to end in order to load the next scene
    IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(waitTime);
        LoadNextScene();
    }

    // Loads the next scene
    public void LoadNextScene()
    {
        SceneManager.LoadScene(++currentSceneIndex);
    }
}
