using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public static bool isPaused;

    void Start () {
        pauseMenu.SetActive(false);
    }

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (isPaused) {
                ResumeGame();
            }
            else {
                PauseGame();
            }
        }
    }

    public void ResumeGame () {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void PauseGame () {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void BackHome() {
        SceneManager.LoadScene("Main Menu");
    }
}
