using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QUACK : MonoBehaviour
{
    public float temp;
    public float def = 7;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(temp > def)
        {

            audio.Play();
            def = Random.Range(0.3f,5);
            temp = 0;
        }
        temp += 1 * Time.deltaTime;
    }
}
//
