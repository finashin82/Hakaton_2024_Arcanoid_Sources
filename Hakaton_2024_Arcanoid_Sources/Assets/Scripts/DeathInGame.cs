using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DeathInGame : MonoBehaviour
{
    [SerializeField] private UnityEvent<DeathInGame> deathInGame;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        deathInGame?.Invoke(this);
    }
}
