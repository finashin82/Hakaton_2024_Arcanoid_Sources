using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    public void GameOverPanel()
    {
        Time.timeScale = 0;
        _gameOverPanel.SetActive(true);
    }   
}
