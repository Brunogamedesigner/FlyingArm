using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPScontroller : MonoBehaviour {

    public CharacterController player;
    private Camera eyes;
    public float walkSpeed;
    public float mouseSensitivity;
    public float gravity;
    public Vector3 movement;
    float moveFowardBack;
    float moveLeftRight;
    float rotationX;
    float rotationY;
    float verticalVelocity;


    // Start is called before the first frame update
    void Start() {
        
        eyes = Camera.main;
        player = gameObject.GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

    }

    // Update is called once per frame
    void Update() {
        
        moveFowardBack = Input.GetAxis("Vertical") * walkSpeed;
        moveLeftRight = Input.GetAxis("Horizontal") * walkSpeed;

        rotationX = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationY -= Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationY = Mathf.Clamp(rotationY, -75f, 75f);

        movement = new Vector3(moveLeftRight, verticalVelocity, moveFowardBack);
        gameObject.transform.Rotate(0, rotationX, 0);
        eyes.gameObject.transform.localRotation = Quaternion.Euler(rotationY, 0, 0);
        movement = gameObject.transform.rotation * movement;
        player.Move(movement * walkSpeed);

        if(player.isGrounded) {

            verticalVelocity = 0;

        } else {

            verticalVelocity += gravity * Time.deltaTime;

        }

    }
}
