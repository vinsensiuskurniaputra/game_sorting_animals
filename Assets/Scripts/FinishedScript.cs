using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishedScript : MonoBehaviour
{
    public TextMeshProUGUI textScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textScore.text = Data.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
