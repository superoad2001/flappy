using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public bool tap;
    public bool tapder;
    public bool tapizq;
    public int posicion = 2;
    public float vel = 1;
    private Rigidbody _rb;
    public Animator baseanim;

    public manager manager;
    public puntaje puntaje;
    public void _tap()
    {
        tap = true;
    }
    public void _tapder()
    {
        tapder = true;
    }
    public void _tapizq()
    {
        tapizq = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        baseanim.SetBool("tap", false);
        if(tap == true)
        {
            _rb.velocity = Vector3.up * vel;
            baseanim.SetBool("tap", true);
        }
        if(tapder == true)
        {
            if (posicion == 1)
            {
                posicion = 2;
            }
            else if (posicion == 2)
            {
                posicion = 3;
            }
        }
        if(tapizq == true)
        {
            if (posicion == 2)
            {
                posicion = 1;
            }
            else if (posicion == 3)
            {
                posicion = 2;
            }
        }
        if (posicion == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(-3,transform.position.y,0),5 * Time.deltaTime);
        }
        if (posicion == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(0,transform.position.y,0),5 * Time.deltaTime);
        }
        if (posicion == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position,new Vector3(3,transform.position.y,0),5 * Time.deltaTime);
        }

        tap = false;
        tapder = false;
        tapizq = false;
        
    }
    public void OnCollisionEnter(Collision col) 
    {
        if(col.gameObject.tag == "mata")
        {
            manager.perder();
        }
        
    }
    public void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject.tag == "puntomas")
        {
            puntaje.puntaje1++;
        }
    }
    
}
