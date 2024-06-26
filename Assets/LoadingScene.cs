using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    public GameObject LoadingScreen;
    public Image LoadingBarFIll;
    
    public void LoadScene(int sceneid) {
        StartCoroutine(LoadSceneAsync(sceneid));
    }

    IEnumerator LoadSceneAsync(int sceneid) {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneid);

        LoadingScreen.SetActive(true);

        while (!operation.isDone) {
            float progressValue = Mathf.Clamp01(operation.progress / 0.9f);

            LoadingBarFIll.fillAmount = progressValue;

            yield return null;
        }
    }
}
