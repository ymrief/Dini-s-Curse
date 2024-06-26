using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void ResumeGame () {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void PauseGame () {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void BackHome() {
        SceneManager.LoadScene(0);
    }
}
