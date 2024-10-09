using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using UnityEngine;
using UnityEngine.UI;

public class puntaje : MonoBehaviour
{
    public int puntaje1 = 0;
    public int record = 0;
    public Text tpunt;
    public Text tpunt2;
    public Text recordt;
    public Text recordt2;
    public Text nrecord;
    public Text nrecord2;
    public google googled;

    public int juego;
    // Start is called before the first frame update
    void Start()
    {
        google googled = UnityEngine.Object.FindObjectOfType<google>();
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        puntaje1 = 0;
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
    }

    // Update is called once per frame
    void Update()
    {
        manager manager = UnityEngine.Object.FindObjectOfType<manager>();
        tpunt.text = "" + puntaje1;
        tpunt2.text = "" + puntaje1;
        if(puntaje1 > record)
        {
            record = puntaje1;
            if(juego == 1)
            {
            manager.datos.record3d = record;
            }
            if(juego == 2)
            {
            manager.datos.record2d = record;
            }
            if(juego == 3)
            {
            manager.datos.recordsalto2d = record;
            }
            manager.guardar();
            nrecord.text = "nuevo record";
            nrecord2.text = "nuevo record";
            google googled = UnityEngine.Object.FindObjectOfType<google>();
    
        #if UNITY_ANDROID
            if(PlayGamesPlatform.Instance.IsAuthenticated())
            {
                if(juego == 1)
                {
                    Social.ReportScore(record, "CgkIq9Xq0KQbEAIQAQ", (bool success) => {});
                }
                if(juego == 2)
                {
                    Social.ReportScore(record, "CgkIq9Xq0KQbEAIQCQ", (bool success) => {});
                }
                if(juego == 3)
                {
                    Social.ReportScore(record, "CgkIq9Xq0KQbEAIQDA", (bool success) => {});
                }
                if(manager.datos.record3d >= 100  || manager.datos.record2d >= 100 || manager.datos.recordsalto2d >= 100)
                {
                    Social.ReportProgress("CgkIq9Xq0KQbEAIQAg", 100.0f, (bool success) => {});
                }
            }
        #endif
            
        }
        recordt.text = "" +record;
        recordt2.text = "" +record;
    }
}
