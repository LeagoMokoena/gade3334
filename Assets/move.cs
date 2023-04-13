using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class move : MonoBehaviour
{
    public float moveSpeed = 5f; // The speed at which the character moves.
    public Vector2Int boardSize; // The size of the board.

    private Vector2Int currentPosition; // The current position of the character on the board.

    void Start()
    {
        // Set the initial position of the character.
        currentPosition = Vector2Int.zero;
    }

    void Update()
    {
        // Get player input.
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Calculate the movement amount.
        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        movement *= moveSpeed * Time.deltaTime;

        // Calculate the new position on the board.
        Vector2Int newBoardPosition = currentPosition + new Vector2Int((int)movement.x, (int)movement.y);

        // Check if the new position is valid.
        if (newBoardPosition.x >= 0 && newBoardPosition.x < boardSize.x &&
            newBoardPosition.y >= 0 && newBoardPosition.y < boardSize.y)
        {
            // Update the current position.
            currentPosition = newBoardPosition;

            // Update the character's position.
            Vector3 newWorldPosition = new Vector3(currentPosition.x, currentPosition.y, 0f);
            transform.position = newWorldPosition;
        }
    }
}


