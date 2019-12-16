using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum Lane { Left, Center, Right};
    private Lane playerLane = Lane.Center;
    [SerializeField]
    float jumpHeight = 1.5f;
    [SerializeField]
    float jumpSpeed = 1f;
    [SerializeField]
    float speed;
    [SerializeField]
    Dictionary<Lane, float> LanePositions = 
        new Dictionary<Lane, float>
        {
            {Lane.Left, -1.5f},
            {Lane.Center, 0f},
            {Lane.Right, 1.5f},
        };
    bool jumping = false;
    bool goingUP = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(speed * Time.deltaTime);
        if (DecoupledInput.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        else if (DecoupledInput.GetKeyDown(KeyCode.D))
        {
            MoveRight();
        }
        if (DecoupledInput.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (jumping)
        {
            Jumping();
        }
    }

    void MoveForward(float distance)
    {
        transform.position += transform.forward * distance;
    }

    void MoveLeft()
    {
        if(playerLane == Lane.Center)
        {
            SetPlayerLane(Lane.Left);
        }
        if(playerLane == Lane.Right)
        {
            SetPlayerLane(Lane.Center);
        }

    }

    void MoveRight()
    {
        if (playerLane == Lane.Center)
        {
            SetPlayerLane(Lane.Right);
        }
        if (playerLane == Lane.Left)
        {
            SetPlayerLane(Lane.Center);
        }
    }

    void SetPlayerLane(Lane lane)
    {
        playerLane = lane;
        transform.position = new Vector3(LanePositions[lane], transform.position.y, transform.position.z);
    }

    void Jump()
    {
        jumping = true;
        goingUP = true;
        Jumping();
    }

    public void Jumping()
    {
        if (goingUP)
        {
            transform.position += new Vector3(0, jumpSpeed * Time.deltaTime, 0);
            if(transform.position.y >= jumpHeight)
            {
                goingUP = false;
            }
        }
        else if (transform.position.y > 0.5)
        {
            transform.position -= new Vector3(0, jumpSpeed * Time.deltaTime, 0);
        }
        else
        {
            jumping = false;
            transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        }
    }
}
