using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class player : MonoBehaviour
{
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player2;
    public bool tap;
    public bool tapder;
    public bool tapizq;
    public int posicion = 2;
    public float vel = 1;
    private Rigidbody _rb;
    public Animator baseanim;
    public AudioSource quack;
    public AudioSource caidas;
    public AudioSource alas;
    public AudioSource alasr;
    public manager manager;
    public puntaje puntaje;
    public float tempb;
    public float record;
    public bool vez1 = false;
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
        player2 = ReInput.players.GetPlayer(playerID);
        record = PlayerPrefs.GetInt("record",-1);
    }

    // Update is called once per frame
    void Update()
    {

        if(player2.GetAxis("a") > 0 && tempb > 0.4f && manager.fin == false)
        {
            tap = true;
            tempb = 0;
        }
        if(player2.GetAxis("hori") < 0 && tempb > 0.4f && manager.fin == false)
        {
            tapizq = true;
            tempb = 0;
        }
        if(player2.GetAxis("hori") > 0 && tempb > 0.4f && manager.fin == false)
        {
            tapder = true;
            tempb = 0;
        }
        baseanim.SetBool("tap", false);
        if(tap == true)
        {
            quack.Play();
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
        if(tempb < 10)
        {
            tempb += 1 * Time.deltaTime;
        }
        
    }
    public void OnCollisionEnter(Collision col) 
    {
        if(col.gameObject.tag == "mata")
        {
            caidas.Play();
            manager.perder();
        }
        
    }
    public void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject.tag == "puntomas")
        {
            alas.Play();
            puntaje.puntaje1++;
            if(puntaje.puntaje1 > record && vez1 == false)
            {
                alasr.Play();
                vez1 = true;
            }
        }
    }
    
}
