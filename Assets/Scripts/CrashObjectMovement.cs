using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashObjectMovement : MonoBehaviour
{
    [SerializeField]
    float startX;
    [SerializeField]
    float endX;
    [SerializeField]
    float speed;

    bool movingToEnd = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (movingToEnd)
        {
            if(transform.position.x < endX)
            {
                transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                movingToEnd = false;
            }
        }
        else
        {
            if (transform.position.x > startX)
            {
                transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            }
            else
            {
                movingToEnd = true;
            }
        }
    }
}
