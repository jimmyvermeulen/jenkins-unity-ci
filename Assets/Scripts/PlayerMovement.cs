using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(speed * Time.deltaTime);
    }

    void MoveForward(float distance)
    {
        transform.position += transform.forward * distance;
    }
}
