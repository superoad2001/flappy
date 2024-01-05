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
    public float dest;
    public bool ant;
    public bool ant2;

    public float altura;
    public float momento = 5;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tuberian = Instantiate(tuberia);
        tuberian.transform.position = transform.position + new Vector3(0,0,10);
        tuberian.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian, 5);

        GameObject tuberian2 = Instantiate(tuberia2);
        tuberian2.transform.position = transform.position + new Vector3(0,0,10);
        tuberian2.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian2, 5);

        GameObject tuberian8 = Instantiate(tuberiabloc);
        tuberian8.transform.position = transform.position + new Vector3(3,-85,10);
        tuberian8.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian8, 5);

        GameObject tuberian9 = Instantiate(tuberiabloc);
        tuberian9.transform.position = transform.position + new Vector3(-3,-85,10);
        tuberian9.GetComponent<tuberia>().momento = 2;
        Destroy(tuberian9, 5);


        GameObject tuberian12 = Instantiate(tuberia);
        tuberian12.transform.position = transform.position + new Vector3(0,3,30);
        tuberian12.GetComponent<tuberia>().momento = 5;
        Destroy(tuberian12, 10);

        GameObject tuberian22 = Instantiate(tuberia2);
        tuberian22.transform.position = transform.position + new Vector3(0,3,30);
        tuberian22.GetComponent<tuberia>().momento = 5;
        Destroy(tuberian22, 10);

        GameObject tuberian82 = Instantiate(tuberiabloc);
        tuberian82.transform.position = transform.position + new Vector3(3,-85,30);
        tuberian82.GetComponent<tuberia>().momento = 5;
        Destroy(tuberian82,10 );

        GameObject tuberian92 = Instantiate(tuberiabloc);
        tuberian92.transform.position = transform.position + new Vector3(-3,-85,30);
        tuberian92.GetComponent<tuberia>().momento = 5;
        Destroy(tuberian92,10);

    }

    // Update is called once per frame
    void Update()
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
                tuberian.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian, dest);

                GameObject tuberian2 = Instantiate(tuberia2);
                tuberian2.transform.position = transform.position + new Vector3(0,dec,30);
                tuberian2.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian2, dest);
            }
            else if (dec4 == 2)
            {
                GameObject tuberian7 = Instantiate(tuberiabloc);
                tuberian7.transform.position = transform.position + new Vector3(0,-85,30);
                tuberian7.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian7, dest);
            }


            if (dec5 == 1)
            {
                GameObject tuberian3 = Instantiate(tuberia);
                tuberian3.transform.position = transform.position + new Vector3(3,dec2,30);
                tuberian3.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian3, dest);

                GameObject tuberian4 = Instantiate(tuberia2);
                tuberian4.transform.position = transform.position + new Vector3(3,dec2,30);
                tuberian4.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian4, dest);
            }
            else if (dec5 == 2)
            {
                GameObject tuberian8 = Instantiate(tuberiabloc);
                tuberian8.transform.position = transform.position + new Vector3(3,-85,30);
                tuberian8.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian8, dest);
            }

            if (dec6 == 1)
            {
                GameObject tuberian5 = Instantiate(tuberia);
                tuberian5.transform.position = transform.position + new Vector3(-3,dec3,30);
                tuberian5.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian5, dest);

                GameObject tuberian6 = Instantiate(tuberia2);
                tuberian6.transform.position = transform.position + new Vector3(-3,dec3,30);
                tuberian6.GetComponent<tuberia>().momento = momento;
                Destroy(tuberian6, dest);
            }
            else if (dec6 == 2)
            {
                GameObject tuberian8 = Instantiate(tuberiabloc);
                tuberian8.transform.position = transform.position + new Vector3(-3,-85,30);
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
