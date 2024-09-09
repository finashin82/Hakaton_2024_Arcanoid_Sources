using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WinLevel : MonoBehaviour
{
    [SerializeField] private GameObject _winPanel;

    private GameObject[] blocks;

    [SerializeField] private UnityEvent<WinLevel> blockEvent;

    public int BlocksCount => blocksCount;

    int blocksCount;

    [SerializeField] private UnityEvent<WinLevel> winLevel;
        
    void Update()
    {
        blocks = GameObject.FindGameObjectsWithTag("Block");

        blocksCount = blocks.Length;

        blockEvent?.Invoke(this);

        if (blocksCount == 0) 
        {
            Time.timeScale = 0;

           _winPanel.SetActive(true);

            winLevel?.Invoke(this);
        }
    }
}
