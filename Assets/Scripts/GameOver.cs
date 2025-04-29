using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    float timer = 0;
    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2)
        {
            Data.score = 0;
            Data.heart = 3;
            Data.time = 60;
            SceneManager.LoadScene("Gameplay");
        }
        
    }
}
