using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tuberia : MonoBehaviour
{
    public float vel;
    public float momento;
    public g_tuberia manager;
    public float temp;
    // Start is called before the first frame update
    void Start()
    {
        manager = UnityEngine.Object.FindObjectOfType<g_tuberia>();
    }

    // Update is called once per frame
    void Update()
    {
        manager = UnityEngine.Object.FindObjectOfType<g_tuberia>();
        transform.position += Vector3.back * vel * Time.deltaTime;

        if(temp > momento && manager.juego == 1)
        {
            vel = 40;
        }
        temp += 1 * Time.deltaTime;
    }
}
