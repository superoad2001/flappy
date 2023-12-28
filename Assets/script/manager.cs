using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;

public class manager : MonoBehaviour
{
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player2;
    public GameObject canvasperdiste;
    public int dec;
    public AudioSource musica;
    public AudioSource musica2;
    public bool fin ;
    public float tempb = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        player2 = ReInput.players.GetPlayer(playerID);
    }

    // Update is called once per frame
    void Update()
    {
        if(player2.GetAxis("b") > 0 && tempb == 1f && fin == true)
        {
            salir();
            tempb = 0;
        }
        if(player2.GetAxis("a") > 0 && tempb == 1f && fin == true)
        {
            reniciar();
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
    public void salir()
    {
        SceneManager.LoadScene("menu");
    }
}
