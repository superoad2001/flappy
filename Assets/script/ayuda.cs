using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayuda : MonoBehaviour
{
    public GameObject ayudaobj;
    // Start is called before the first frame update
    void Start()
    {
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        if(manager.datos.ayuda == true)
        {
            ayudaobj.SetActive(true);
        }
        else{ayudaobj.SetActive(false);}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
