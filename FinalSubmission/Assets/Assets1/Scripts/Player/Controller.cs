using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Controller : MonoBehaviour
{

    public Rigidbody2D myRigidbody = null;
    public float moveSpeed = 10.0f;
    private InputManager inputManager;

    private void Start()
    {
        inputManager = InputManager.instance;
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        Vector3 movementVector = new Vector3(-inputManager.horizontalMoveAxis, 0, -inputManager.verticalMoveAxis);
        transform.position = transform.position + (movementVector * Time.deltaTime * moveSpeed);

    }

}