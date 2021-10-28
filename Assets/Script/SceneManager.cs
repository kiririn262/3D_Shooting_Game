using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    // フィールドの追加
    public Text GameOverText;
    public Image BackGroundImage;
    public Text ClearText;
    public Text ScoreText;
    int _currentScore = 0;
    //メソッドの追加
    private void Start()
    {
        GameOverText.gameObject.SetActive(false);
        BackGroundImage.gameObject.SetActive(false);
        ClearText.gameObject.SetActive(false);

        ScoreText.text = _currentScore.ToString();
    }
    void Quit() {
    #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
    #elif UNITY_STANDALONE
      UnityEngine.Application.Quit();
    #endif
  }
  void Update () {
    if (Input.GetKey(KeyCode.Escape)) Quit();
  }
    public void ShowGameOver()
    {
        GameOverText.gameObject.SetActive(true);
        BackGroundImage.gameObject.SetActive(true);
    }
    public void ShowClear()
    {
        ClearText.gameObject.SetActive(true);
    }
    public void AddScore(int score)
    {
        _currentScore += score;
        ScoreText.text = _currentScore.ToString();
    }
}