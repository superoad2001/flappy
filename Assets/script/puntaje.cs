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

    public bool juego3d;
    public bool juego2d;
    // Start is called before the first frame update
    void Start()
    {
        google googled = UnityEngine.Object.FindObjectOfType<google>();
        puntaje1 = 0;
        if(juego3d)
        {
        record = PlayerPrefs.GetInt("record",0);
        }
        if(juego2d)
        {
        record = PlayerPrefs.GetInt("record2d",0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        tpunt.text = "" + puntaje1;
        tpunt2.text = "" + puntaje1;
        if(puntaje1 > record)
        {
            record = puntaje1;
            if(juego3d)
            {
            PlayerPrefs.SetInt("record",record);
            }
            if(juego2d)
            {
            PlayerPrefs.SetInt("record2d",record);
            }
            nrecord.text = "nuevo record";
            nrecord2.text = "nuevo record";
            google googled = UnityEngine.Object.FindObjectOfType<google>();
    
        #if UNITY_ANDROID
            if(PlayGamesPlatform.Instance.IsAuthenticated())
            {
                if(juego3d)
                {
                    Social.ReportScore(record, "CgkIq9Xq0KQbEAIQAQ", (bool success) => {});
                }
                if(juego2d)
                {
                    Social.ReportScore(record, "CgkIq9Xq0KQbEAIQCQ", (bool success) => {});
                }
                if(PlayerPrefs.GetInt("record",0) >= 100)
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
