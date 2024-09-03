using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{  
    [SerializeField] private float speed;   

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }   

    /// <summary>
    /// Движение в игре
    /// </summary>
    /// <param name="direction"></param>
    /// <param name="isJumpButtonPressed"></param>
    public void Move(float direction)
    {        
        if (Mathf.Abs(direction) > 0.01f)
        {
            HorizontalMovement(direction);
        }
    }    

    /// <summary>
    /// Горизонтальное движение (direction - направление)
    /// </summary>
    /// <param name="direction"></param>
    private void HorizontalMovement(float direction)
    {        
        rb.velocity = new Vector2(direction * speed, rb.velocity.y);
    }    
}
