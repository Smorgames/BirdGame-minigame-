using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GAME_MANAGER : MonoBehaviour
{
    public static GAME_MANAGER instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private TextMeshProUGUI _scorePointAmount;
    private int _scorePoint;

    [SerializeField] private GameObject _losePanel;

    private void Start()
    {
        SetPoint(0);
    }

    public void SetPoint(int amount)
    {
        _scorePoint = amount;
        _scorePointAmount.text = _scorePoint.ToString();
    }

    public void AddPoint(int amount)
    {
        _scorePoint += amount;
        _scorePointAmount.text = _scorePoint.ToString();
    }

    public int GetScore()
    {
        return _scorePoint;
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        _losePanel.SetActive(true);
    }
}
