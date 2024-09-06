using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    /// <summary>
    /// �������� ������ � ������ ������
    /// </summary>
    /// <param name="health"></param>
    public void DeathBlock(Health health)
    {
        // ���� ������� ����� ������ ��� ����� 0, �� ������ �������� � ������� �������
        if (!health.IsAlive)
        {
            gameObject.SetActive(false);
            
            //Coroutine coroutin = StartCoroutine(timer());
        }
    }

    // ������������ ������� ����� ������
    private IEnumerator timer()
    {
        // �������� �������� ����� 2 �������
        yield return new WaitForSeconds(0.5f);

        gameObject.SetActive(false);
    }
}
