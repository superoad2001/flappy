using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private Controles controles;

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
    public float tempd;
    public float record;
    public bool vez1 = false;
    public int juego = 1;
    public bool suelo;
    public float tempc;
    public void Awake()
    {
        controles = new Controles();
    }
    private void OnEnable() 
    {
        controles.Enable();
    }
    private void OnDisable() 
    {
        controles.Disable();
    }
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
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        if(juego == 1)
        {
        record = manager.datos.record3d;
        }
        if(juego == 2)
        {
        record = manager.datos.record2d;
        }
        if(juego == 3)
        {
            record = manager.datos.recordsalto2d;
        }
        if(juego == 4)
        {
            record = manager.datos.recordsalto3d;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if(controles.Base.space.ReadValue<float>() > 0 && manager.fin == false)
        {
            tap = true;
            tempb = 0;
        }
        if(controles.Base.izq.ReadValue<float>() > 0 && manager.fin == false)
        {
            tapizq = true;
            tempb = 0;
        }
        if(controles.Base.der.ReadValue<float>() > 0 && manager.fin == false)
        {
            tapder = true;
            tempb = 0;
        }
        baseanim.SetBool("tap", false);
        if(tap == true)
        {
            if(juego == 1 || juego == 2)
            {
                quack.Play();
                _rb.linearVelocity = Vector3.up * vel;
                baseanim.SetBool("tap", true);
                tempd = 0;
            }
            if(juego == 3 || juego == 4)
            {
                if(suelo == true)
                {
                    quack.Play();
                    _rb.linearVelocity = Vector3.up * vel;
                    baseanim.SetBool("suelo", true);
                    tempc = 0;
                }
            }
            
        }
        if(juego == 2 && tempd > 0.4)
        {
            _rb.linearVelocity = Vector3.up * -3;
            tempd = 0;
        }
        if(juego == 1 && tempd > 0.6)
        {
            _rb.linearVelocity = Vector3.up * -3;
            tempd = 0;
        }
        if(juego == 1 || juego == 4 )
        {
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
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(-3,transform.position.y,0),10 * Time.deltaTime);
            }
            if (posicion == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(0,transform.position.y,0),10 * Time.deltaTime);
            }
            if (posicion == 3)
            {
                transform.position = Vector3.MoveTowards(transform.position,new Vector3(3,transform.position.y,0),10 * Time.deltaTime);
            }
        }

        tap = false;
        tapder = false;
        tapizq = false;
        if(suelo == false && tempc > 0.9 && juego == 3)
        {
            _rb.linearVelocity = Vector3.up * -10;
            tempc = 0;
        }
        if(suelo == false && tempc > 0.65 && juego == 4)
        {
            _rb.linearVelocity = Vector3.up * -20;
            tempc = 0;
        }
        if(tempb < 10)
        {
            tempb += 1 * Time.deltaTime;
        }
        if(tempc < 10)
        {
            tempc += 1 * Time.deltaTime;
        }
        if(tempd < 10)
        {
            tempd += 1 * Time.deltaTime;
        }
        
    }
    public void OnCollisionEnter(Collision col) 
    {
        if(col.gameObject.tag == "mata")
        {
            caidas.Play();
            manager.perder();
        }
        if(col.gameObject.tag == "suelo")
        {
            suelo = true;
            baseanim.SetBool("suelo", false);
        }
        
    }
    public void OnCollisionExit(Collision col) 
    {
        if(col.gameObject.tag == "suelo")
        {
            suelo = false;
        }
        
    }
    public void OnTriggerEnter(Collider col) 
    {
        if(col.gameObject.tag == "mata")
        {
            caidas.Play();
            manager.perder();
        }
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
