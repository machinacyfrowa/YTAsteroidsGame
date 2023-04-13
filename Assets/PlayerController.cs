using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 2f;
    private Vector2 movementVector;
    // Start is called before the first frame update
    void Start()
    {
        movementVector = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementVector * Time.deltaTime * moveSpeed);
    }

    void OnMove(InputValue inputValue)
    {
        movementVector = inputValue.Get<Vector2>();
        Debug.Log("Wywo³ano metodê OnMove(). Otrzymano wartoœæ: " + movementVector.ToString());
    }
}
