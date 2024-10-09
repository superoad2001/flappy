using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyrotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float velrot;
    // Update is called once per frame
    void Update()
    {
        
        RenderSettings.skybox.SetFloat("_Rotation",Time.time * velrot);
    }
}
