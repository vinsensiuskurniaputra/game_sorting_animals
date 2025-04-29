using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public int heart = 3;
    public float time = 60;
    public TextMeshProUGUI textHeart;
    public TextMeshProUGUI textTime;
    void Start()
    {
        Data.heart = heart;
        Data.time = time;
        textHeart.text = Data.heart.ToString();
        textTime.text = Mathf.CeilToInt(Data.time).ToString();
    }

    void Update()
    {
        if (Data.time > 0)
        {
            Data.time -= Time.deltaTime;
            if (textTime != null)
                textTime.text = Mathf.CeilToInt(Data.time).ToString();

            if (Data.time <= 0)
            {
                Data.time = 0;
                SceneManager.LoadScene("Finished");
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision);
        Data.heart -= 1;
        textHeart.text = Data.heart.ToString();
        if (Data.heart == 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
