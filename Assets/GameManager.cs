using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public float slowDownFactor = 10f;

    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    private IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowDownFactor;
        Time.fixedDeltaTime /= slowDownFactor;
        yield return new WaitForSeconds(1f / slowDownFactor);
        Time.timeScale *= slowDownFactor;
        Time.fixedDeltaTime *= slowDownFactor;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
