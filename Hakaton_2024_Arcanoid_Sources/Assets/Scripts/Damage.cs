using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Урон от пули
    [SerializeField] private float damage;

    //private void OnCollisionEnter2D(Collider2D collision)
    //{
    //    Debug.Log("+");

    //    // Если у объекта есть скрипт с жизнью, то можем нанести ему урон
    //    if (collision.gameObject.TryGetComponent<Health>(out var health))
    //    {
    //        // У объекта с которым столкнулся мач, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
    //        health.TakeDamage(damage);
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Если у объекта есть скрипт с жизнью, то можем нанести ему урон
        if (collision.gameObject.TryGetComponent<Health>(out var health))
        {
            // У объекта с которым столкнулся мач, вызывается скрипт "Health" и метод "TakeDamage" с параметром damage (Уменьшает здоровье)
            health.TakeDamage(damage);
        }
    }
}
