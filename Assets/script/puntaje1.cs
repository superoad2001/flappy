using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje1 : MonoBehaviour
{
    public static int record = 0;
    public Text recordt;
    public Text recordt2;
    // Start is called before the first frame update
    void Start()
    {
        google googled = UnityEngine.Object.FindObjectOfType<google>();
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();

        record = manager.datos.record3d;
    }

    // Update is called once per frame
    void Update()
    {
        recordt.text = "" +record;
        recordt2.text = "" +record;
    }
}
