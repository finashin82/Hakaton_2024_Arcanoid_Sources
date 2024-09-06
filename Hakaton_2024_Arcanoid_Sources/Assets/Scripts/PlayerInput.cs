using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
   
    private void Awake()
    {
        playerMovement = GetComponent<PlayerMovement>();        
    }

    private void Update()
    {        
        float horizontalDirection = Input.GetAxis(GlobalStringVars._horizontalAxis);        

        playerMovement.Move(horizontalDirection);
    }
}
