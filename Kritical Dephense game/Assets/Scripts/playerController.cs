using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D _rb;//instance of player rigid body
    float moveSpeed = 8;
    float movementX, movementY;

    public Camera cam; //instance of main camera game object
    Vector2 mousePos;//mouse position
    Vector2 lookDir; //direction player looks in (vector)
    float lookAngle; //angle the player looks in


    // Start is called before the first frame update
    void Start()
    {
        //set camera
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        _rb = GetComponent<Rigidbody2D>();

    }

    void Update() //handles inputs each frame
    {
        //player left right, up down walking movement
        movementX = Input.GetAxisRaw("Horizontal");//returns -1 A, 1 D
        movementY = Input.GetAxisRaw("Vertical");//returns -1 S, 1 W

        // getting te position of player mouse
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);//converting pixle mouse position to an exact point using the main camera object

    }

    private void FixedUpdate()//handles reliable physics (not dependend on frame rate)
    {
        _rb.velocity = new Vector2(movementX * moveSpeed, movementY * moveSpeed);


        //direction vector the player is looking in
        lookDir = mousePos - _rb.position;//
        lookAngle = Mathf.Atan2(lookDir.y,lookDir.x) *Mathf.Rad2Deg -90f;//returns angle between x axis and 2D vector

        _rb.rotation = lookAngle;
    }



}
