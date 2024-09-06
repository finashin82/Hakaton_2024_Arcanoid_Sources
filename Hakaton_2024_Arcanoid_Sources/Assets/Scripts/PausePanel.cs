using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;

    private bool isAction;

    // Start is called before the first frame update
    void Start()
    {
        isAction = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isAction)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }

            _pausePanel.gameObject.SetActive(isAction);

            isAction = !isAction;
        }
    }
}
