using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public enum Lane { Left, Center, Right};
    private Lane playerLane = Lane.Center;
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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.A))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MoveRight();
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
        transform.position = new Vector3(LanePositions[lane], transform.position.y);
    }
}
