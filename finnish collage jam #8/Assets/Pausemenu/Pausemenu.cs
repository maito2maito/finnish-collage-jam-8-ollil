using UnityEngine;
using UnityEngine.SceneManagement; // Jos haluat vaihtaa kohtauksia
using UnityEngine.UI; // UI-elementtien k‰sittelyyn

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuUI; // Pausen menu UI (Panel)
    public Button resumeButton; // Resume-nappi
    public Button quitButton; // Quit-nappi

    private bool isPaused = false;

    void Update()
    {
        // Tarkistetaan, onko pelaaja painanut ESC-n‰pp‰int‰
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false); // Piilottaa valikon
        Time.timeScale = 1f; // Palauttaa pelin normaalin nopeuden
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked; // Est‰‰ hiiren vapaan liikkumisen peliss‰
        Cursor.visible = false; // Piilottaa hiiren
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true); // N‰ytt‰‰ valikon
        Time.timeScale = 0f; // Pys‰ytt‰‰ pelin
        isPaused = true;
        Cursor.lockState = CursorLockMode.None; // Sallii hiiren liikkumisen
        Cursor.visible = true; // N‰ytt‰‰ hiiren
    }

    public void Quit()
    {
        // Voit lis‰t‰ t‰h‰n pelist‰ poistuvan toiminnon, esim. SceneManager.LoadScene("MainMenu");
        Application.Quit(); // Sulkee pelin
    }
}
