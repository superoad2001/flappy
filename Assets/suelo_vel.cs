using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suelo_vel : MonoBehaviour
{
    public float vel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.z <= -201.2f)
        {
            transform.position = new Vector3 (transform.position.x,transform.position.y,500);
        }
        transform.position = new Vector3 (transform.position.x,transform.position.y,transform.position.z - vel * Time.deltaTime);
    }
}
