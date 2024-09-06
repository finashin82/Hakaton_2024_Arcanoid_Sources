using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    [SerializeField] private Text _blockCountInGame;

    public void BlocksCountInGame(WinLevel winLevel)
    {
        _blockCountInGame.text = winLevel.BlocksCount.ToString();
    }
}
