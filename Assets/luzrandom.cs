using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzrandom : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        Color color1 = new Color(
            (float)Random.Range(0, 255), 
            (float)Random.Range(0, 255), 
            (float)Random.Range(0, 255)
        );
        Color color2 = new Color(
            (float)Random.Range(0, 255), 
            (float)Random.Range(0, 255), 
            (float)Random.Range(0, 255)
        );
        Color color3 = new Color(
            (float)Random.Range(0, 255), 
            (float)Random.Range(0, 255), 
            (float)Random.Range(0, 255)
        );
        
        var intensity1 = (color1.r + color1.g + color1.b) / 3f;
        var factor1 = 1 / intensity1;
        
        var intensity2 = (color2.r + color2.g + color2.b) / 3f;
        var factor2 = 1 / intensity2;

        var intensity3 = (color3.r + color3.g + color3.b) / 3f;
        var factor3 = 1 / intensity3;

        color1 = new Color(
            color1.r*factor1, 
            color1.g*factor1, 
            color1.b*factor1
        );
        color2 = new Color(
            color2.r*factor2, 
            color2.g*factor2, 
            color2.b*factor2
        );
        color3 = new Color(
            color3.r*factor3, 
            color3.g*factor3, 
            color3.b*factor3
        );

        RenderSettings.ambientEquatorColor = color1;
        RenderSettings.ambientGroundColor = color2;
        RenderSettings.ambientSkyColor = color3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
