using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje1 : MonoBehaviour
{
    public static int record = 0;
    public Text recordt;
    // Start is called before the first frame update
    void Start()
    {
        record = PlayerPrefs.GetInt("record",0);
    }

    // Update is called once per frame
    void Update()
    {
        recordt.text = "" +record;
    }
}
