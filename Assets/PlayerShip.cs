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
    public float rollInput;

    //Speed Multipliers
    public float speedMult = 1f;
    public float speedMultAngle = 0.5f;
    [SerializeField]
    float speedRollMultAngle = 0.05f;


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
        rollInput = Input.GetAxis("Roll");

        mouseInputX = Input.GetAxis("Mouse X");
        mouseInputY = Input.GetAxis("Mouse Y");
    }

    private void FixedUpdate()
    {
        playershipRB.AddForce(playershipRB.transform.TransformDirection(Vector3.forward) * verticalMove * speedMult, ForceMode.VelocityChange);
    }
}
