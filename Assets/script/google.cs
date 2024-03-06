using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.SocialPlatforms;


public class google : MonoBehaviour
{


  public string puesto1;
  public string puesto2;
  public string puesto3;



    void Awake()
    {
        #if UNITY_ANDROID
        //Initialize PlayGamesPlatform
        PlayGamesPlatform.Activate();
        PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication);
        #endif
    }
    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);

        #if UNITY_ANDROID
        





        #endif
        
        
    }
    public void LoadUsers(string tabla)
    {

        var lb = PlayGamesPlatform.Instance.CreateLeaderboard();
        lb.id = tabla;


        PlayGamesPlatform.Instance.LoadScores
        (
          lb.id , // Leaderboard ID
          LeaderboardStart.PlayerCentered, // Get from top scores or player centered
          5, // number of rows of scores you want
          LeaderboardCollection.Public, // public scores or social
          LeaderboardTimeSpan.AllTime, // Time span
          (LeaderboardScoreData data) => // callback with scores
          {                

                puesto1 = "1r: "+data.Scores[0].userID+"     "+data.Scores[0].formattedValue;
                puesto2 = "2o: "+data.Scores[1].userID+"     "+data.Scores[1].formattedValue;
                puesto3 = "3r: "+data.Scores[2].userID+"     "+data.Scores[2].formattedValue;

          }
        );

    }
    

    internal void ProcessAuthentication(SignInStatus status) {
      if (status == SignInStatus.Success) {
        // Continue with Play Games Services
      } else {
        // Disable your integration with Play Games Services or show a login button
        // to ask users to sign-in. Clicking it should call
        // PlayGamesPlatform.Instance.ManuallyAuthenticate(ProcessAuthentication).
      }
    }


    public void clas()
    {
        Social.ShowLeaderboardUI();
    }
    public void trof()
    {
        Social.ShowAchievementsUI();
    }
}

