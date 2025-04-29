using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControl : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoPlayAgain()
    {
        Data.score = 0;
        Data.heart = 3;
        Data.time = 60;
        SceneManager.LoadScene("Gameplay");
    }
}
