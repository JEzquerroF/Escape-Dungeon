using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public static int currentScenes = 0;

    void Update()
    {
        currentScenes = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(2);

        CheckHiScore();
    }

    private void CheckHiScore()
    {
        if (HUD.score > PlayerPrefs.GetFloat("HighScore", 0.0f))
        {
            PlayerPrefs.SetFloat("HighScore", HUD.score);
        }
    }
}
