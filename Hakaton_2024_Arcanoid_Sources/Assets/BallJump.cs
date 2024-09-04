using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallJump : MonoBehaviour
{
    [SerializeField] private GameObject _platform;

    private Rigidbody2D rb;

    private bool ballIsActive;
    private Vector3 ballPosition;
    private Vector2 ballInitialForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // создаем силу
        ballInitialForce = new Vector2(100.0f, 300.0f);

        // переводим в неактивное состояние
        ballIsActive = false;

        // запоминаем положение
        ballPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // проверка нажатия на пробел
        if (Input.GetButtonDown("Jump") == true)
        {
            // проверка состояния
            if (!ballIsActive)
            {
                // сброс всех сил
                rb.isKinematic = false;

                // применим силу
                rb.AddForce(ballInitialForce);

                // зададим активное состояние
                ballIsActive = !ballIsActive;
            }
        }

        if (!ballIsActive && _platform != null)
        {
            // задаем новую позицию шарика
            ballPosition.x = _platform.transform.position.x;

            // устанавливаем позицию шара
            transform.position = ballPosition;
        }
    }
}
