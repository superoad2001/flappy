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
    // Start is called before the first frame update
    void Start()
    {
        GameObject tuberian = Instantiate(tuberia);
        tuberian.transform.position = transform.position + new Vector3(0,0,10);
        Destroy(tuberian, 3);

        GameObject tuberian2 = Instantiate(tuberia2);
        tuberian2.transform.position = transform.position + new Vector3(0,0,10);
        Destroy(tuberian2, 3);

        GameObject tuberian8 = Instantiate(tuberiabloc);
        tuberian8.transform.position = transform.position + new Vector3(3,-85,10);
        Destroy(tuberian8, 3);

        GameObject tuberian9 = Instantiate(tuberiabloc);
        tuberian9.transform.position = transform.position + new Vector3(-3,-85,10);
        Destroy(tuberian9, 3);



        GameObject tuberian12 = Instantiate(tuberia);
        tuberian12.transform.position = transform.position + new Vector3(0,3,30);
        Destroy(tuberian12, 6);

        GameObject tuberian22 = Instantiate(tuberia2);
        tuberian22.transform.position = transform.position + new Vector3(0,3,30);
        Destroy(tuberian22, 6);

        GameObject tuberian82 = Instantiate(tuberiabloc);
        tuberian82.transform.position = transform.position + new Vector3(3,-85,30);
        Destroy(tuberian82,6 );

        GameObject tuberian92 = Instantiate(tuberiabloc);
        tuberian92.transform.position = transform.position + new Vector3(-3,-85,30);
        Destroy(tuberian92, 6);

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
        


        
            if (dec4 == 1)
            {
                GameObject tuberian = Instantiate(tuberia);
                tuberian.transform.position = transform.position + new Vector3(0,dec,30);
                Destroy(tuberian, dest);

                GameObject tuberian2 = Instantiate(tuberia2);
                tuberian2.transform.position = transform.position + new Vector3(0,dec,30);
                Destroy(tuberian2, dest);
            }
            else if (dec4 == 2)
            {
                GameObject tuberian7 = Instantiate(tuberiabloc);
                tuberian7.transform.position = transform.position + new Vector3(0,-85,30);
                Destroy(tuberian7, dest);
            }


            if (dec5 == 1)
            {
                GameObject tuberian3 = Instantiate(tuberia);
                tuberian3.transform.position = transform.position + new Vector3(3,dec2,30);
                Destroy(tuberian3, dest);

                GameObject tuberian4 = Instantiate(tuberia2);
                tuberian4.transform.position = transform.position + new Vector3(3,dec2,30);
                Destroy(tuberian4, dest);
            }
            else if (dec5 == 2)
            {
                GameObject tuberian8 = Instantiate(tuberiabloc);
                tuberian8.transform.position = transform.position + new Vector3(3,-85,30);
                Destroy(tuberian8, dest);
            }

            if (dec6 == 1)
            {
                GameObject tuberian5 = Instantiate(tuberia);
                tuberian5.transform.position = transform.position + new Vector3(-3,dec3,30);
                Destroy(tuberian5, dest);

                GameObject tuberian6 = Instantiate(tuberia2);
                tuberian6.transform.position = transform.position + new Vector3(-3,dec3,30);
                Destroy(tuberian6, dest);
            }
            else if (dec6 == 2)
            {
                GameObject tuberian8 = Instantiate(tuberiabloc);
                tuberian8.transform.position = transform.position + new Vector3(-3,-85,30);
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
