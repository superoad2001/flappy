using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Rewired;
using UnityEditor;
using UnityEngine.UI;
using GooglePlayGames;
using System.IO;

public class manager : MonoBehaviour
{
    [SerializeField]private int playerID = 0;
	[SerializeField]private Player player2;

    public Text record1;
    public Text record2;
    public Text record3;
    public Text helptext;
    public InputField namet;

    public int juego;

    public bool namec;
    
    public GameObject canvasperdiste;
    public int dec;
    public AudioSource musicah;
    public AudioSource musica;
    public AudioSource musicas;
    public AudioSource musica2;
    public AudioSource musica3;
    public AudioSource musica4;
    public AudioSource musica5;
    public List<AudioSource> audios = new List<AudioSource>();
    public bool fin ;
    public float tempb = 0;

    public bool Menu;
    public GameObject bot1;
    public GameObject bot2;
    public bool juegom;

    [SerializeField]
    public datos datos;

    public string repath;

    public void GetFilePath()
    {
        string result;

    	result = Path.Combine(Application.persistentDataPath,"Fallbird");
        result = Path.Combine(result, $"Fallbirddata.data");

		#if UNITY_EDITOR
    	result = Path.Combine(Application.persistentDataPath,"FallbirdDev");
        result = Path.Combine(result, $"Fallbirddata.data");
		#endif
 
        repath = result;
    }
    public void guardar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosc = JsonUtility.ToJson(datos);
            File.WriteAllText(path,datosc);
            Debug.Log(datosc);
        }
        else if(!File.Exists(path))
        {
            System.IO.FileInfo file = new System.IO.FileInfo(path);
            file.Directory.Create();
            string datosc = JsonUtility.ToJson(datos);
            File.WriteAllText(path,datosc);
            Debug.Log(datosc);
        }
        
    }
    public void cargar()
    {
        GetFilePath();
        string path = repath;
        if(File.Exists(path))
        {
            string datosc = File.ReadAllText(path);
            datos = JsonUtility.FromJson<datos>(datosc);
            Debug.Log(datosc);
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        if(Menu == false)
        {
        audios.Add(musica);
        audios.Add(musica2);
        audios.Add(musica3);
        audios.Add(musica4);
        audios.Add(musica5);
        int dec = Random.Range(1,4);
        musicah = audios[dec];
        musicah.Play();
        }
        cargar();
        google googled = UnityEngine.Object.FindObjectOfType<google>();
        Time.timeScale = 1;
        player2 = ReInput.players.GetPlayer(playerID);
        #if UNITY_ANDROID
        if(PlayGamesPlatform.Instance.IsAuthenticated())
        {
            if(juego == 1)
            {
                //googled.LoadUsers("CgkIq9Xq0KQbEAIQAQ");
            }
            if(juego == 2)
            {
                //googled.LoadUsers("CgkIq9Xq0KQbEAIQCQ");
            }
        }
        #endif

    }
    public bool vez1;
    // Update is called once per frame
    void Update()
    {

        if(player2.GetButtonDown("b") && fin == true)
        {
            if(Menu == true)
            {
                salir2();
            }
            else
            {
                salir();
            }
            tempb = 0;
        }
        if(player2.GetButtonDown("a") && fin == true)
        {
            reniciar();
            tempb = 0;
        }




        google googled = UnityEngine.Object.FindObjectOfType<google>();
        if(vez1 == false)
        {
            vez1 = true;
        }
        if(tempb < 10)
        {
            tempb += 1 * Time.deltaTime;
        }

        
    }
    public void perder()
    {
        tempb = 1;
        canvasperdiste.SetActive(true);
        musicah.Stop();
        musicas.Play();
        fin = true;
        Time.timeScale = 0;
        
    }
    public void salir2()
    {
        Application.Quit();
    }
    public void salir()
    {
        SceneManager.LoadScene("menu");
    }
    public void reniciar()
    {
        int dec = Random.Range(1,5);
        if(dec == 1)
        {
        SceneManager.LoadScene("caida2d");
        }
        if(dec == 2)
        {
        SceneManager.LoadScene("caida3d");
        }
        if(dec == 3)
        {
        SceneManager.LoadScene("salto2d");
        }
        if(dec == 4)
        {
        SceneManager.LoadScene("salto3d");
        }

    }

}
