using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] Text _highScoreText;
    [SerializeField] Text _currentScoreText;

    void Start()
    {
        UpdateHiScoreText();

        _currentScoreText.text = "Current  Score: " + System.Math.Round(HUD.score, 1);
    }

    private void UpdateHiScoreText()
    {
        _highScoreText.text = "HighScore: " + System.Math.Round(PlayerPrefs.GetFloat("HighScore", 0.0f), 1);
    }
}
