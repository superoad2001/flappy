using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje : MonoBehaviour
{
    public static int puntaje1 = 0;
    public static int record = 0;
    public Text tpunt;
    public Text tpunt2;
    public Text recordt;
    public Text recordt2;
    public Text nrecord;
    public Text nrecord2;
    // Start is called before the first frame update
    void Start()
    {
        puntaje1 = 0;
        record = PlayerPrefs.GetInt("record",0);
    }

    // Update is called once per frame
    void Update()
    {
        tpunt.text = "" + puntaje1;
        tpunt2.text = "" + puntaje1;
        if(puntaje1 > record)
        {
            record = puntaje1;
            PlayerPrefs.SetInt("record",record);
            nrecord.text = "nuevo record";
            nrecord2.text = "nuevo record";
            
        }
        recordt.text = "" +record;
        recordt2.text = "" +record;
    }
}
