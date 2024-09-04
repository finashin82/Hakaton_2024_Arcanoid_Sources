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
        // ������� ����
        ballInitialForce = new Vector2(100.0f, 300.0f);

        // ��������� � ���������� ���������
        ballIsActive = false;

        // ���������� ���������
        ballPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // �������� ������� �� ������
        if (Input.GetButtonDown("Jump") == true)
        {
            // �������� ���������
            if (!ballIsActive)
            {
                // ����� ���� ���
                rb.isKinematic = false;

                // �������� ����
                rb.AddForce(ballInitialForce);

                // ������� �������� ���������
                ballIsActive = !ballIsActive;
            }
        }

        if (!ballIsActive && _platform != null)
        {
            // ������ ����� ������� ������
            ballPosition.x = _platform.transform.position.x;

            // ������������� ������� ����
            transform.position = ballPosition;
        }
    }
}
