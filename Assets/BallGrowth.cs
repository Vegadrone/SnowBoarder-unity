using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGrowth : MonoBehaviour
{
    //Variable Declaration
    [SerializeField] float scalingX = 0f;
    [SerializeField] float scalingY = 0f;
    [SerializeField] float scalingZ = 0f;

    Rigidbody2D rigidBody;

    private void Start()
    {
        // Take RigidBody2D Component from GO
        rigidBody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // Take Velocity from rigidBody
        Vector3 velocity = rigidBody.velocity;

        // Calculate velocityOverTime
        float velocityOverTime = velocity.magnitude;

        Debug.Log("Velocity: " + velocityOverTime);

        if (Mathf.Abs(GetComponent<Rigidbody2D>().velocity.y) > 0.01f) 
{
            transform.localScale += new Vector3(scalingX, scalingY, scalingZ) * Time.deltaTime;
        }

    }
}

