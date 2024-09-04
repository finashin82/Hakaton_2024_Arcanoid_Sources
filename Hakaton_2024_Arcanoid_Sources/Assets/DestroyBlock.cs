using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    /// <summary>
    /// Анимация смерти и смерть игрока
    /// </summary>
    /// <param name="health"></param>
    public void DeathBlock(Health health)
    {
        // Если текущая жизнь меньше или равна 0, то запуск анимации и скрытие объекта
        if (!health.IsAlive)
        {
            gameObject.SetActive(false);
            
            //Coroutine coroutin = StartCoroutine(timer());
        }
    }

    // Исчезновение объекта после смерти
    private IEnumerator timer()
    {
        // Вызывает действие через 2 секунды
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
