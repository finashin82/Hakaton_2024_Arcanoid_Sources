using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    [SerializeField] private GameObject _platform;

    private Rigidbody2D rb;

    private bool isActiveBall;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Start()
    {
        // создаем силу
        ballInitialForce = new Vector2(100.0f, 300.0f);

        // переводим в неактивное состояние
        isActiveBall = false;

        // запоминаем положение
        ballPosition = transform.position;
    }
    
    void Update()
    {
        // проверка нажатия на пробел
        if (Input.GetButtonDown("Jump") == true)
        {
            // проверка состояния
            if (!isActiveBall)
            {
                // сброс всех сил
                rb.isKinematic = false;

                // применим силу
                rb.AddForce(ballInitialForce);

                // зададим активное состояние
                isActiveBall = !isActiveBall;
            }
        }

        if (!isActiveBall && _platform != null)
        {
            // задаем новую позицию шарика
            ballPosition.x = _platform.transform.position.x;

            // устанавливаем позицию шара
            transform.position = ballPosition;
        }
    }
}
