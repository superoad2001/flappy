using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class g_tuberiam : MonoBehaviour
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

    public float altura;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tuberian = Instantiate(tuberia);
        tuberian.transform.position = transform.position + new Vector3(0,0,10);
        Destroy(tuberian, dest);

        GameObject tuberian2 = Instantiate(tuberia2);
        tuberian2.transform.position = transform.position + new Vector3(0,0,10);
        Destroy(tuberian2, dest);

        GameObject tuberian8 = Instantiate(tuberiabloc);
        tuberian8.transform.position = transform.position + new Vector3(3,-85,10);
        Destroy(tuberian8, dest);

        GameObject tuberian9 = Instantiate(tuberiabloc);
        tuberian9.transform.position = transform.position + new Vector3(-3,-85,10);
        Destroy(tuberian9, dest);



        GameObject tuberian12 = Instantiate(tuberia);
        tuberian12.transform.position = transform.position + new Vector3(0,0,30);
        Destroy(tuberian12, dest);

        GameObject tuberian22 = Instantiate(tuberia2);
        tuberian22.transform.position = transform.position + new Vector3(0,0,30);
        Destroy(tuberian22, dest);

        GameObject tuberian82 = Instantiate(tuberiabloc);
        tuberian82.transform.position = transform.position + new Vector3(3,-85,30);
        Destroy(tuberian82,dest );

        GameObject tuberian92 = Instantiate(tuberiabloc);
        tuberian92.transform.position = transform.position + new Vector3(-3,-85,30);
        Destroy(tuberian92, dest);

    }

    // Update is called once per frame
    void Update()
    {
        if(tempin > tempmax)
        {

        GameObject tuberian = Instantiate(tuberia);
        tuberian.transform.position = transform.position + new Vector3(0,0,30);
        Destroy(tuberian, dest);

        GameObject tuberian2 = Instantiate(tuberia2);
        tuberian2.transform.position = transform.position + new Vector3(0,0,30);
        Destroy(tuberian2, dest);

        GameObject tuberian3 = Instantiate(tuberiabloc);
        tuberian3.transform.position = transform.position + new Vector3(3,-85,30);
        Destroy(tuberian3, dest);

        GameObject tuberian4 = Instantiate(tuberiabloc);
        tuberian4.transform.position = transform.position + new Vector3(-3,-85,30);
        Destroy(tuberian4, dest);
        tempin = 0;
           
        }
        else
        {
            tempin += Time.deltaTime;
        }
    }
}
