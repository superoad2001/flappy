using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dianoche : MonoBehaviour
{
    public bool lado = true; 
    public bool vez = false; 
    public float back;
    public float back2;
    void Awake()
    {

        GameObject[] objs = GameObject.FindGameObjectsWithTag("dia");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        if(vez == false)
        {
        RenderSettings.reflectionIntensity = 1;
        RenderSettings.skybox.SetFloat("_Exposure",1);
        back = RenderSettings.reflectionIntensity;
        back2 = RenderSettings.skybox.GetFloat("_Exposure");
        vez = true;
        }
        DontDestroyOnLoad(this.gameObject);
        RenderSettings.reflectionIntensity = back;
    }
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.reflectionIntensity = back;
        RenderSettings.skybox.SetFloat("_Exposure",back2 );

    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Exposure",back2 );
        RenderSettings.reflectionIntensity = back;
        if(RenderSettings.reflectionIntensity <= 0)
        {
            lado = true;
        }
        if(RenderSettings.reflectionIntensity >= 2)
        {
            lado = false;
        }
        if(lado == true)
        {
            RenderSettings.skybox.SetFloat("_Exposure", RenderSettings.skybox.GetFloat("_Exposure") + 0.04f * Time.deltaTime);
            RenderSettings.reflectionIntensity += 0.04f * Time.deltaTime;
        }
        if(lado == false)
        {
            RenderSettings.skybox.SetFloat("_Exposure", RenderSettings.skybox.GetFloat("_Exposure") + -0.04f * Time.deltaTime);
            RenderSettings.reflectionIntensity += -0.04f * Time.deltaTime;
        }
        back = RenderSettings.reflectionIntensity;
        back2 = RenderSettings.skybox.GetFloat("_Exposure");
    }
}
