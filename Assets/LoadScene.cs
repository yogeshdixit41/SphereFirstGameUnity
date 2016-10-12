using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadScreen1(string sceneName)
    {
        Debug.Log(""+sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
