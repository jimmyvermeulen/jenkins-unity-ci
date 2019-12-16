using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTextureTiling : MonoBehaviour
{
    [SerializeField]
    float horizontalTiling;
    [SerializeField]
    float verticalTiling;
    Material material;

    // Start is called before the first frame update
    void Start()
    {
        ScaleTexture();
    }
    
    void ScaleTexture()
    {
        material = GetComponent<MeshRenderer>().material;
        material.mainTextureScale = new Vector2(horizontalTiling * transform.lossyScale.x * 10, 
                                                verticalTiling * transform.lossyScale.z * 10);
    }
}
