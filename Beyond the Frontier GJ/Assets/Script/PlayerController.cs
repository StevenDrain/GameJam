using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float speed = 3;
    public float rotationSpeed = 90;
    public float gravity = -20f;
    public float jumpSpeed = 5;

    public gunScript gunScript;
    public powerup powerup;

    public float powerDuration = 3f;
    CharacterController characterController;
    Vector3 moveVelocity;
    Vector3 turnVelocity;

    void Awake()
    {
        characterController = GetComponent<CharacterController>();

    }

    void Update()
    {
        var hInput = Input.GetAxis("Horizontal");
        var vInput = Input.GetAxis("Vertical");

        if (characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                moveVelocity.y = jumpSpeed;
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                speed += 5;
            }
            else if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                speed -= 5;
            }
        }

        // Move forward/backward only if grounded and not jumping
        if (characterController.isGrounded && !Input.GetKeyDown("space"))
        {
            moveVelocity = transform.forward * speed * vInput;
        }

        // Turn left/right
        turnVelocity = transform.up * rotationSpeed * hInput;

        // Apply gravity
        moveVelocity.y += gravity * Time.deltaTime;

        // Move the character
        characterController.Move(moveVelocity * Time.deltaTime);

        // Rotate the character
        transform.Rotate(turnVelocity * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Powerup"))
        {
            StartCoroutine(PowerupDuration());
            Destroy(col.gameObject);

        }
    }
    IEnumerator PowerupDuration()
    {
        gunScript.fireRate -= 2;
        yield return new WaitForSeconds(powerDuration);
        gunScript.fireRate += 2;

    }
}