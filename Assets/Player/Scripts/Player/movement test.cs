using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.WSA;

public class movementtest : MonoBehaviour
{
    public Transform Ship;
    public Rigidbody Rbody;


    //speed
    public float turnSpeed = 60f;
    public float boostSpeed = 45f;


    //futrue variables
    private void Start()
    {
        Rbody = GetComponent<Rigidbody>();
        Rbody.useGravity = false;
        UnityEngine.Cursor.lockState = CursorLockMode.Locked;
    }


    private void FixedUpdate()
    {
        Turn();
        Thrust();
    }

    void Turn()
    {
        float yaw = turnSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
        float pitch = turnSpeed * Time.deltaTime * Input.GetAxis("Vertical");
        float roll = turnSpeed * Time.deltaTime * Input.GetAxis("Rotate");
        Ship.Rotate(roll, yaw, pitch);
    }

    void Thrust()
    {
        Ship.position += Ship.right * boostSpeed * Time.deltaTime * Input.GetAxis("Throttle");
    }
}
