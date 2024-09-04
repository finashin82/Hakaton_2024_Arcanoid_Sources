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
        // ������� ����
        ballInitialForce = new Vector2(100.0f, 300.0f);

        // ��������� � ���������� ���������
        isActiveBall = false;

        // ���������� ���������
        ballPosition = transform.position;
    }
    
    void Update()
    {
        // �������� ������� �� ������
        if (Input.GetButtonDown("Jump") == true)
        {
            // �������� ���������
            if (!isActiveBall)
            {
                // ����� ���� ���
                rb.isKinematic = false;

                // �������� ����
                rb.AddForce(ballInitialForce);

                // ������� �������� ���������
                isActiveBall = !isActiveBall;
            }
        }

        if (!isActiveBall && _platform != null)
        {
            // ������ ����� ������� ������
            ballPosition.x = _platform.transform.position.x;

            // ������������� ������� ����
            transform.position = ballPosition;
        }
    }
}
