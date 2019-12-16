using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DecoupledInput : MonoBehaviour
{
    static Dictionary<KeyCode, bool> Key = new Dictionary<KeyCode, bool>
    {
        {KeyCode.A, false},
        {KeyCode.D, false},
        {KeyCode.Space, false}
    };

    static Dictionary<KeyCode, bool> KeyDown = new Dictionary<KeyCode, bool>
    {
        {KeyCode.A, false},
        {KeyCode.D, false},
        {KeyCode.Space, false}
    };

    static Dictionary<KeyCode, bool> KeyUp = new Dictionary<KeyCode, bool>
    {
        {KeyCode.A, false},
        {KeyCode.D, false},
        {KeyCode.Space, false}
    };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (KeyCode key in Key.Keys.ToArray())
        {
            Debug.Log(key.ToString());
            if (Input.GetKeyDown(key))
            {
                Key[key] = true;
                KeyDown[key] = true;
            }
            else
            {
                KeyDown[key] = false;
            }

            if (Input.GetKeyUp(key))
            {
                Key[key] = false;
                KeyUp[key] = true;
            }
            else
            {
                KeyUp[key] = false;
            }
        }

        
    }

    public static void SetKeyDown(KeyCode key)
    {
        Key[key] = true;
        KeyDown[key] = true;
    }

    public static void SetKeyUp(KeyCode key)
    {
        Key[key] = false;
        KeyUp[key] = true;
    }

    public static bool GetKeyDown(KeyCode key)
    {
        return KeyDown[key];
    }

    public static bool GetKey(KeyCode key)
    {
        return Key[key];
    }

    public static bool GetKeyUp(KeyCode key)
    {
        return Key[key];
    }

}
