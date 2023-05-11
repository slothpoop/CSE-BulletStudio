using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Leaderboards : MonoBehaviour 
{
    [SerializeField]
    public List<TextMeshProUGUI> user;
    [SerializeField]
    public List<TextMeshProUGUI> scores;

    private string publicLeaderboardKey = "5e380368d2a911c5f89a59125529fe84d779a3cddf8581372b0f418f5e8fbbf5";

    public void GetLeaderboard() {
        LeaderboardCreator.GetLeaderboard(publicLeaderboardKey, ((msg) => {
            for (int i = 0; i < user.Count; ++i ) {
                user[i].text = msg[i].User;
                scores[i].text = msg[i].Score.ToString();
            }
        }));
    }

    public void SetLeaderboardEntry(string username, int score) {
        LeaderboardCreator.UploadNewEntry(publicLeaderboardKey, username, score, ((msg) =>  {
            GetLeaderboard();
        }));
    }
}
