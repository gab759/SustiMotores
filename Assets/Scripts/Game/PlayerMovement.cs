﻿using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D myRB;
    private float limitSuperior;
    private float limitInferior;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        SetMinMax();
    }

    void SetMinMax()
    {
        Vector3 bounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        limitInferior = -bounds.y;
        limitSuperior = bounds.y;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Candy")
        {
            
        }

        if(other.tag == "Enemy")
        {
            
        }
    }

    public void OnMovement(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
        {
            speed = ctx.ReadValue<float>();
        }
    }
    void FixedUpdate()
    {
        Vector2 currentPosition = myRB.position;
        float moveY = speed * Time.deltaTime    ; 
        Vector2 newPosition = new Vector2(currentPosition.x, currentPosition.y + moveY);

        newPosition.y = Mathf.Clamp(newPosition.y, limitInferior, limitSuperior);

        myRB.MovePosition(newPosition);
    }   
}
