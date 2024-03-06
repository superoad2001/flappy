using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEditor;
using UnityEngine.UI;
using GooglePlayGames;

public class manager : MonoBehaviour
{
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player2;

    public Text record1;
    public Text record2;
    public Text record3;

    public InputField namet;

    public bool juego;

    public bool namec;
    
    public GameObject canvasperdiste;
    public int dec;
    public AudioSource musica;
    public AudioSource musica2;
    public bool fin ;
    public float tempb = 0;

    public bool Menu;
    public GameObject bot1;
    public GameObject bot2;
    public bool juego3d;
    public bool juego2d;
    // Start is called before the first frame update
    void Start()
    {
        google googled = UnityEngine.Object.FindObjectOfType<google>();
        Time.timeScale = 1;
        player2 = ReInput.players.GetPlayer(playerID);

        if(Menu)
        {
        bot1.SetActive(false);
        bot2.SetActive(false);
        #if UNITY_ANDROID
        bot1.SetActive(true);
        bot2.SetActive(true);
        #endif
        }
        if(PlayGamesPlatform.Instance.IsAuthenticated())
        {
        if(juego3d)
        {

        #if UNITY_ANDROID
        googled.LoadUsers("CgkIq9Xq0KQbEAIQAQ");
        #endif
        }
        if(juego2d)
        {
        #if UNITY_ANDROID
        googled.LoadUsers("CgkIq9Xq0KQbEAIQCQ");
        #endif
        }
        if(juego)
        {
            record1.text = googled.puesto1;
            record2.text = googled.puesto2;
            record3.text = googled.puesto3;
        }
        }

    }
    public bool vez1;
    // Update is called once per frame
    void Update()
    {
        if(player2.GetAxis("b") > 0 && tempb == 1f && fin == true)
        {
            salir();
            tempb = 0;
        }
        if(player2.GetAxis("a") > 0 && tempb == 1f && fin == true && juego3d)
        {
            reniciar();
            tempb = 0;
        }
        if(player2.GetAxis("a") > 0 && tempb == 1f && fin == true && juego2d)
        {
            reniciar2d();
            tempb = 0;
        }
        if(player2.GetAxis("a") == 0 && tempb == 0 && fin == true)
        {
            tempb = 1;
        }
        if(player2.GetAxis("a") > 0 && fin == false)
        {
            tempb = 0;
        }




        google googled = UnityEngine.Object.FindObjectOfType<google>();
        if(vez1 == false)
        {
            vez1 = true;
        }

        
    }
    public void perder()
    {
        canvasperdiste.SetActive(true);
        Time.timeScale = 0;
        musica.Stop();
        musica2.Play();
        fin = true;
        tempb = 1;
    }
    public void reniciar()
    {
        google googled = UnityEngine.Object.FindObjectOfType<google>();
        dec = Random.Range(1,5);
        if(dec == 1)
        {
            SceneManager.LoadScene("juego");
        }
        if(dec == 2)
        {
            SceneManager.LoadScene("juego2");
        }
        if(dec == 3)
        {
            SceneManager.LoadScene("juego3");
        }
        if(dec == 4)
        {
            SceneManager.LoadScene("juego4");
        }

    }
    public void reniciar2d()
    {
        SceneManager.LoadScene("juego2d");

    }
    public void salir()
    {
        SceneManager.LoadScene("menu");
    }
}
