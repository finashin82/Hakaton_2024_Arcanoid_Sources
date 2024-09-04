using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBlock : MonoBehaviour
{
    [Header("Значения для цвета")]
    [SerializeField] private int _colorYellow;
    [SerializeField] private int _colorBlue;
    [SerializeField] private int _colorRed;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void ColorBlockInGame(Health health)
    {
        if (health.CurrentHealth == _colorYellow)
        {
            spriteRenderer.color = Color.yellow;
        }

        if (health.CurrentHealth == _colorBlue)
        {
            spriteRenderer.color = Color.blue;
        }

        if (health.CurrentHealth == _colorRed)
        {
            spriteRenderer.color = Color.red;
        }
    }
}
