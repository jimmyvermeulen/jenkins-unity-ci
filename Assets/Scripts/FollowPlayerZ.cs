using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerZ : MonoBehaviour
{
    Vector3 startOffset;
    [SerializeField]
    Transform playerTransform;

    private void Start()
    {
        startOffset = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x, startOffset.y, playerTransform.position.z + startOffset.z);
    }
}
