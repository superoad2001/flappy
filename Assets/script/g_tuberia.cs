using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_tuberia : MonoBehaviour
{
    public float tempmax = 1;
    public float tempin = 0;
    public GameObject tuberia;
    public GameObject tuberia2;
    public GameObject tuberiabloc;
    public float dec;
    public float dec2;
    public float dec3;
    public float dec4;
    public float dec5;
    public float dec6;
    public float dec7;
    public float dec8;
    public float dest;
    public bool ant;
    public bool ant2;

    public float altura;
    public float momento = 5;
    public int juego;
    // Start is called before the first frame update
    void Start()
    {



        if(juego == 2)
        {
        GameObject tuberian12 = Instantiate(tuberia);
        tuberian12.transform.position = transform.position + new Vector3(0,3,30);
        tuberian12.GetComponent<tuberia>().momento = 99;
        Destroy(tuberian12, 10);

        GameObject tuberian22 = Instantiate(tuberia2);
        tuberian22.transform.position = transform.position + new Vector3(0,3,30);
        tuberian22.GetComponent<tuberia>().momento = 99;
        Destroy(tuberian22, 10);

        GameObject tuberian = Instantiate(tuberia);
        tuberian.transform.position = transform.position + new Vector3(0,0,10);
        tuberian.GetComponent<tuberia>().momento = 99;
        Destroy(tuberian, 5);

        GameObject tuberian2 = Instantiate(tuberia2);
        tuberian2.transform.position = transform.position + new Vector3(0,0,10);
        tuberian2.GetComponent<tuberia>().momento = 99;
        Destroy(tuberian2, 5);
        
        }
        if(juego == 3)
        {
        GameObject tuberian12 = Instantiate(tuberia);
        tuberian12.transform.position = transform.position + new Vector3(0,-4,30);
        tuberian12.GetComponent<tuberia>().momento = 5;
        Destroy(tuberian12, 10);

        GameObject tuberian = Instantiate(tuberia);
        tuberian.transform.position = transform.position + new Vector3(0,-3,10);
        tuberian.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian, 5);
        }
        if(juego == 4)
        {

        GameObject tuberian999 = Instantiate(tuberia);
        tuberian999.transform.position = transform.position + new Vector3(0,-3,30);
        tuberian999.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian999, 5);

        GameObject tuberian9991 = Instantiate(tuberiabloc);
        tuberian9991.transform.position = transform.position + new Vector3(3,-85,30);
        tuberian9991.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian9991, 5);

        GameObject tuberian9992 = Instantiate(tuberiabloc);
        tuberian9992.transform.position = transform.position + new Vector3(-3,-85,30);
        tuberian9992.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian9992, 5);



            int distanciai = 30;
            for(int i = 0; i < 8; i++)
            {
            distanciai += 30;
            dec = Random.Range(-altura,altura);
            dec2 = Random.Range(-altura,altura);
            dec3 = Random.Range(-altura,altura);

            dec4 = Random.Range(1,3);
            dec5 = Random.Range(1,3);
            dec6 = Random.Range(1,3);

            if(dec4 == 2 && dec5 == 2 && dec6 == 2)
            {
                dec4 = 1;
            }



            if(dec4 == 2 && dec5 == 1 && dec6 == 2)
            {
                ant = true;
            }
            else if(dec4 == 2 && dec5 == 2 && dec6 == 1 && ant == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant = false;
            }
            
            
            if(dec4 == 2 && dec5 == 2 && dec6 == 1)
            {
                ant2 = true;
            }
            else if(dec4 == 2 && dec5 == 1 && dec6 == 2 && ant2 == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant2 = false;
            }
            


                momento = 6;
                if (dec4 == 1)
                {
                    dec8 = Random.Range(1,4);

                    if(dec8 == 1)
                    {
                    dec7 = Random.Range(-3,-1);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    tempin = 0;
                    }
                    if(dec8 == 2)
                    {
                    
                    dec7 = Random.Range(-2,-2);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(0,dec7,distanciai+3);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);

                    tempin = 0;
                    }
                    if(dec8 == 3)
                    {
                    dec7 = Random.Range(-5,-3);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(0,dec7,distanciai+3);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(0,dec7,distanciai+6);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    tempin = 0;
                    }
                }
                else if (dec4 == 2)
                {
                    GameObject tuberian7 = Instantiate(tuberiabloc);
                    tuberian7.transform.position = transform.position + new Vector3(0,-85,distanciai);
                    tuberian7.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian7, dest);
                }


                if (dec5 == 1)
                {
                    dec8 = Random.Range(1,4);

                    if(dec8 == 1)
                    {
                    dec7 = Random.Range(-3,-1);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(3,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    tempin = 0;
                    }
                    if(dec8 == 2)
                    {
                    
                    dec7 = Random.Range(-2,-2);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(3,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(3,dec7,distanciai+3);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);

                    tempin = 0;
                    }
                    if(dec8 == 3)
                    {
                    dec7 = Random.Range(-5,-3);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(3,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(3,dec7,distanciai+3);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(3,dec7,distanciai+6);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    tempin = 0;
                    }
                }
                else if (dec5 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(3,-85,distanciai);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }

                if (dec6 == 1)
                {
                    dec8 = Random.Range(1,4);

                    if(dec8 == 1)
                    {
                    dec7 = Random.Range(-3,-1);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(-3,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    tempin = 0;
                    }
                    if(dec8 == 2)
                    {
                    
                    dec7 = Random.Range(-2,-2);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(-3,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(-3,dec7,distanciai+3);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);

                    tempin = 0;
                    }
                    if(dec8 == 3)
                    {
                    dec7 = Random.Range(-5,-3);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(-3,dec7,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(-3,dec7,distanciai+3);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(-3,dec7,distanciai+6);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    tempin = 0;
                    }
                }
                else if (dec6 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(-3,-85,distanciai);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }
                tempin = 0;
            
    
            }
        }

        if(juego == 1)
        {
        GameObject tuberian9998 = Instantiate(tuberiabloc);
        tuberian9998.transform.position = transform.position + new Vector3(3,-85,30);
        tuberian9998.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian9998, 5);

        GameObject tuberian9999 = Instantiate(tuberiabloc);
        tuberian9999.transform.position = transform.position + new Vector3(-3,-85,30);
        tuberian9999.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian9999, 5);

        GameObject tuberian999 = Instantiate(tuberia);
        tuberian999.transform.position = transform.position + new Vector3(0,0,30);
        tuberian999.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian999, 5);

        GameObject tuberian9992 = Instantiate(tuberia2);
        tuberian9992.transform.position = transform.position + new Vector3(0,0,30);
        tuberian9992.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian9992, 5);

            int distanciai = 30;
            for(int i = 0; i < 8; i++)
            {
            distanciai += 30;
            dec = Random.Range(-altura,altura);
            dec2 = Random.Range(-altura,altura);
            dec3 = Random.Range(-altura,altura);

            dec4 = Random.Range(1,3);
            dec5 = Random.Range(1,3);
            dec6 = Random.Range(1,3);

            if(dec4 == 2 && dec5 == 2 && dec6 == 2)
            {
                dec4 = 1;
            }



            if(dec4 == 2 && dec5 == 1 && dec6 == 2)
            {
                ant = true;
            }
            else if(dec4 == 2 && dec5 == 2 && dec6 == 1 && ant == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant = false;
            }
            
            
            if(dec4 == 2 && dec5 == 2 && dec6 == 1)
            {
                ant2 = true;
            }
            else if(dec4 == 2 && dec5 == 1 && dec6 == 2 && ant2 == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant2 = false;
            }
            


                momento = 6;
                if (dec4 == 1)
                {
                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec,distanciai);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    GameObject tuberian2 = Instantiate(tuberia2);
                    tuberian2.transform.position = transform.position + new Vector3(0,dec,distanciai);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                }
                else if (dec4 == 2)
                {
                    GameObject tuberian7 = Instantiate(tuberiabloc);
                    tuberian7.transform.position = transform.position + new Vector3(0,-85,distanciai);
                    tuberian7.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian7, dest);
                }


                if (dec5 == 1)
                {
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(3,dec2,distanciai);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    GameObject tuberian4 = Instantiate(tuberia2);
                    tuberian4.transform.position = transform.position + new Vector3(3,dec2,distanciai);
                    tuberian4.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian4, dest);
                }
                else if (dec5 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(3,-85,distanciai);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }

                if (dec6 == 1)
                {
                    GameObject tuberian5 = Instantiate(tuberia);
                    tuberian5.transform.position = transform.position + new Vector3(-3,dec3,distanciai);
                    tuberian5.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian5, dest);

                    GameObject tuberian6 = Instantiate(tuberia2);
                    tuberian6.transform.position = transform.position + new Vector3(-3,dec3,distanciai);
                    tuberian6.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian6, dest);
                }
                else if (dec6 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(-3,-85,distanciai);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }
                tempin = 0;
            
    
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if(juego == 1)
        {


            if(tempin > tempmax)
            {
            dec = Random.Range(-altura,altura);
            dec2 = Random.Range(-altura,altura);
            dec3 = Random.Range(-altura,altura);

            dec4 = Random.Range(1,3);
            dec5 = Random.Range(1,3);
            dec6 = Random.Range(1,3);

            if(dec4 == 2 && dec5 == 2 && dec6 == 2)
            {
                dec4 = 1;
            }



            if(dec4 == 2 && dec5 == 1 && dec6 == 2)
            {
                ant = true;
            }
            else if(dec4 == 2 && dec5 == 2 && dec6 == 1 && ant == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant = false;
            }
            
            
            if(dec4 == 2 && dec5 == 2 && dec6 == 1)
            {
                ant2 = true;
            }
            else if(dec4 == 2 && dec5 == 1 && dec6 == 2 && ant2 == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant2 = false;
            }
            


                momento = 6;
                if (dec4 == 1)
                {
                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    GameObject tuberian2 = Instantiate(tuberia2);
                    tuberian2.transform.position = transform.position + new Vector3(0,dec,270);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                }
                else if (dec4 == 2)
                {
                    GameObject tuberian7 = Instantiate(tuberiabloc);
                    tuberian7.transform.position = transform.position + new Vector3(0,-85,270);
                    tuberian7.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian7, dest);
                }


                if (dec5 == 1)
                {
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(3,dec2,270);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    GameObject tuberian4 = Instantiate(tuberia2);
                    tuberian4.transform.position = transform.position + new Vector3(3,dec2,270);
                    tuberian4.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian4, dest);
                }
                else if (dec5 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(3,-85,270);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }

                if (dec6 == 1)
                {
                    GameObject tuberian5 = Instantiate(tuberia);
                    tuberian5.transform.position = transform.position + new Vector3(-3,dec3,270);
                    tuberian5.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian5, dest);

                    GameObject tuberian6 = Instantiate(tuberia2);
                    tuberian6.transform.position = transform.position + new Vector3(-3,dec3,270);
                    tuberian6.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian6, dest);
                }
                else if (dec6 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(-3,-85,270);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }
                tempin = 0;
            
    
            }
            else
            {
                tempin += Time.deltaTime;
            }
        }
        if(juego == 2)
        {


            if(tempin > tempmax)
            {
            dec = Random.Range(-altura,altura);
            


                momento = 20;

                GameObject tuberian = Instantiate(tuberia);
                tuberian.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian, dest);

                GameObject tuberian2 = Instantiate(tuberia2);
                tuberian2.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian2.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian2, dest);

                tempin = 0;
    
            }
            else
            {
                tempin += Time.deltaTime;
            }
        }
        if(juego == 3)
        {
            if(tempin > tempmax)
            {

                dec2 = Random.Range(1,4);

                if(dec2 == 1)
                {
                dec = Random.Range(-3,-1);
                momento = 6;

                GameObject tuberian = Instantiate(tuberia);
                tuberian.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian, dest);

                tempin = 0;
                tempmax = Random.Range(3,4);
                }
                if(dec2 == 2)
                {
                    
                dec = Random.Range(-2,-2);
                momento = 6;

                GameObject tuberian = Instantiate(tuberia);
                tuberian.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian, dest);
                GameObject tuberian2 = Instantiate(tuberia);
                tuberian2.transform.position = transform.position + new Vector3(0,dec,33);
                tuberian2.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian2, dest);

                tempin = 0;
                tempmax = Random.Range(3,4);
                }
                if(dec2 == 3)
                {
                dec = Random.Range(-5,-3);
                momento = 6;

                GameObject tuberian = Instantiate(tuberia);
                tuberian.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian, dest);
                GameObject tuberian2 = Instantiate(tuberia);
                tuberian2.transform.position = transform.position + new Vector3(0,dec,33);
                tuberian2.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian2, dest);
                GameObject tuberian3 = Instantiate(tuberia);
                tuberian3.transform.position = transform.position + new Vector3(0,dec,36);
                tuberian3.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian3, dest);

                tempin = 0;
                tempmax = Random.Range(3,5);
                }
    
            }
            else
            {
                tempin += Time.deltaTime;
            }
        }
        if(juego == 4)
        {


            if(tempin > tempmax)
            {
            dec = Random.Range(-altura,altura);
            dec2 = Random.Range(-altura,altura);
            dec3 = Random.Range(-altura,altura);

            dec4 = Random.Range(1,3);
            dec5 = Random.Range(1,3);
            dec6 = Random.Range(1,3);

            if(dec4 == 2 && dec5 == 2 && dec6 == 2)
            {
                dec4 = 1;
            }



            if(dec4 == 2 && dec5 == 1 && dec6 == 2)
            {
                ant = true;
            }
            else if(dec4 == 2 && dec5 == 2 && dec6 == 1 && ant == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant = false;
            }
            
            
            if(dec4 == 2 && dec5 == 2 && dec6 == 1)
            {
                ant2 = true;
            }
            else if(dec4 == 2 && dec5 == 1 && dec6 == 2 && ant2 == true)
            {
                dec4 = 1;
                dec5 = 2;
                dec6 = 2;
                ant2 = false;
            }
            


                momento = 6;
                if (dec4 == 1)
                {
                    dec8 = Random.Range(1,4);

                    if(dec8 == 1)
                    {
                    dec7 = Random.Range(-3,-1);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    tempin = 0;
                    }
                    if(dec8 == 2)
                    {
                    
                    dec7 = Random.Range(-2,-2);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(0,dec7,273);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);

                    tempin = 0;
                    }
                    if(dec8 == 3)
                    {
                    dec7 = Random.Range(-5,-3);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(0,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(0,dec7,273);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(0,dec7,276);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    tempin = 0;
                    }
                }
                else if (dec4 == 2)
                {
                    GameObject tuberian7 = Instantiate(tuberiabloc);
                    tuberian7.transform.position = transform.position + new Vector3(0,-85,270);
                    tuberian7.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian7, dest);
                }


                if (dec5 == 1)
                {
                    dec8 = Random.Range(1,4);

                    if(dec8 == 1)
                    {
                    dec7 = Random.Range(-3,-1);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(3,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    tempin = 0;
                    }
                    if(dec8 == 2)
                    {
                    
                    dec7 = Random.Range(-2,-2);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(3,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(3,dec7,273);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);

                    tempin = 0;
                    }
                    if(dec8 == 3)
                    {
                    dec7 = Random.Range(-5,-3);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(3,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(3,dec7,273);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(3,dec7,276);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    tempin = 0;
                    }
                }
                else if (dec5 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(3,-85,270);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }

                if (dec6 == 1)
                {
                    dec8 = Random.Range(1,4);

                    if(dec8 == 1)
                    {
                    dec7 = Random.Range(-3,-1);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(-3,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);

                    tempin = 0;
                    }
                    if(dec8 == 2)
                    {
                    
                    dec7 = Random.Range(-2,-2);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(-3,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(-3,dec7,273);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);

                    tempin = 0;
                    }
                    if(dec8 == 3)
                    {
                    dec7 = Random.Range(-5,-3);
                    momento = 6;

                    GameObject tuberian = Instantiate(tuberia);
                    tuberian.transform.position = transform.position + new Vector3(-3,dec7,270);
                    tuberian.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian, dest);
                    GameObject tuberian2 = Instantiate(tuberia);
                    tuberian2.transform.position = transform.position + new Vector3(-3,dec7,273);
                    tuberian2.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian2, dest);
                    GameObject tuberian3 = Instantiate(tuberia);
                    tuberian3.transform.position = transform.position + new Vector3(-3,dec7,276);
                    tuberian3.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian3, dest);

                    tempin = 0;
                    }
                }
                else if (dec6 == 2)
                {
                    GameObject tuberian8 = Instantiate(tuberiabloc);
                    tuberian8.transform.position = transform.position + new Vector3(-3,-85,270);
                    tuberian8.GetComponent<tuberia>().momento = momento;
                    Destroy(tuberian8, dest);
                }
                tempin = 0;
            
    
            }
            else
            {
                tempin += Time.deltaTime;
            }
        }
    }
}
