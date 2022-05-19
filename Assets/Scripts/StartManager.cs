using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StartManager : MonoBehaviour
{

    public static StartManager Instance;
    public string userName;
    public string userNameBest;
    public int bestScoreBest;
    private MainManager MainManager;
    

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadBestScore();

    }
    public void UserNameEdit(string input)
    {
        userName = input;
    }


    [System.Serializable]
    public class SaveData
    {
        public int bestScoreBest;
        public string userNameBest;
    }
    public void BestScore()
    {  
        SaveData data = new SaveData();
        data.bestScoreBest = bestScoreBest;
        data.userNameBest = userNameBest;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadBestScore()
{
    string path = Application.persistentDataPath + "/savefile.json";
    if (File.Exists(path))
    {
        string json = File.ReadAllText(path);
        SaveData data = JsonUtility.FromJson<SaveData>(json);

        bestScoreBest = data.bestScoreBest;
        userNameBest = data.userNameBest;
    }
}
    //public void LoadColor()
    //{
    //    string path = Application.persistentDataPath + "/savefile.json";
    //    if(File.Exists(path))
    //    {
    //        string json = File.ReadAllText(path);
    //        SaveData data = JsonUtility.FromJson<SaveData>(json);

    //        TeamColor = data.TeamColor;
    //    }
    //}



}
