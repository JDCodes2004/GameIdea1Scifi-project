using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    public Rigidbody playershipRB;

    //Inputs/Movement
    public float verticalMove;
    public float horizontalMove;
    public float mouseInputX;
    public float mouseInputY;

    //Speed Multipliers
    public float speedMult = 1f;
    public float speedMultAngle = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playershipRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove = Input.GetAxis("Horizontal");

        mouseInputX = Input.GetAxis("Mouse X");
        mouseInputY = Input.GetAxis("Mouse Y");
    }

    private void FixedUpdate()
    {
        playershipRB.AddForce(verticalMove * speedMult * playershipRB.transform.TransformDirection(Vector3.forward), ForceMode.VelocityChange);

        playershipRB.AddForce(horizontalMove * speedMult * playershipRB.transform.TransformDirection(Vector3.right), ForceMode.VelocityChange);

        playershipRB.AddTorque(playershipRB.transform.right * speedMultAngle * mouseInputY * -1, ForceMode.VelocityChange);
        playershipRB.AddTorque(playershipRB.transform.up * speedMultAngle * mouseInputX, ForceMode.VelocityChange);
        

    }
}
