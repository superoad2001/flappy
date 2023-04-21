using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public GameObject canvasperdiste;
    public int dec;
    public AudioSource musica;
    public AudioSource musica2;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void perder()
    {
        canvasperdiste.SetActive(true);
        Time.timeScale = 0;
        musica.Stop();
        musica2.Play();
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
