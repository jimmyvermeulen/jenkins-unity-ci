using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashObject : MonoBehaviour
{
    public delegate void CrashEvent();
    public static event CrashEvent OnCrashedInto;

    private void OnTriggerEnter(Collider other)
    {
        OnCrashedInto?.Invoke();
        Destroy(gameObject);
    }
}
