using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class Manager : MonoBehaviour {

    [DllImport("__Internal")] public static extern int GetUserIdFromJS();
    [DllImport("__Internal")] public static extern string GetLanguageFromJS();
    [DllImport("__Internal")] public static extern void SendInfiniteBlocksRecordFromJS(int userId, int score, int level);
    [DllImport("__Internal")] public static extern int GetInfiniteBlocksHighScoreFromJS();
    [DllImport("__Internal")] public static extern void SetInfiniteBlocksHighScoreFromJS(int highScore);
    [DllImport("__Internal")] public static extern void DestroyInfiniteBlocksHighScoreFromJS();
    [DllImport("__Internal")] public static extern int GetInfiniteBlocksMaxLevelFromJS();
    [DllImport("__Internal")] public static extern void SetInfiniteBlocksMaxLevelFromJS(int maxLevel);
    [DllImport("__Internal")] public static extern void DestroyInfiniteBlocksMaxLevelFromJS();

    [SerializeField] Text textUserId;
    [SerializeField] Text textScore;
    [SerializeField] Text textLevel;
    [SerializeField] Text textHighScore;
    [SerializeField] Text textMaxLevel;
    [SerializeField] Text textLanguage;

    [SerializeField] InputField inputFieldUserId;
    [SerializeField] InputField inputFieldScore;
    [SerializeField] InputField inputFieldLevel;
    [SerializeField] InputField inputFieldHighScore;
    [SerializeField] InputField inputFieldMaxLevel;

    int userId = 0;
    int score = 0;
    int level = 1;
    int highScore = 0;
    int maxLevel = 1;
    string language = "English";
	// Use this for initialization
	void Start () {
        //userId = GetUserIdFromJS();
        //language = GetLanguageFromJS();
	}
	
	// Update is called once per frame
	void Update () {
        textUserId.text = userId.ToString();
        textScore.text = score.ToString();
        textLevel.text = level.ToString();
        textHighScore.text = highScore.ToString();
        textMaxLevel.text = maxLevel.ToString();
        textLanguage.text = language;
	}

    public void PushUserId()
    {
        int number = int.Parse(inputFieldUserId.text);
        userId = number;
    }

    public void PushScore()
    {
        int number = int.Parse(inputFieldScore.text);
        if (number >= 0 && number < 1000000) score = number;
    }

    public void PushLevel()
    {
        int number = int.Parse(inputFieldLevel.text);
        if (number > 0 && number <= 30) level = number;
    }

    public void PushHighScore()
    {
        int number = int.Parse(inputFieldHighScore.text);
        if (number >= 0 && number < 1000000) highScore = number;
    }

    public void PushMaxLevel()
    {
        int number = int.Parse(inputFieldMaxLevel.text);
        if (number > 0 && number <= 30) maxLevel = number;
    }

    public void PushSendRecord()
    {
        SendInfiniteBlocksRecordFromJS(userId, score, level);
    }

    public void PushGetHighScore()
    {
        GetInfiniteBlocksHighScoreFromJS();
    }

    public void PushSetHighScore()
    {
        SetInfiniteBlocksHighScoreFromJS(highScore);
    }

    public void PushDestroyHighScore()
    {
        DestroyInfiniteBlocksHighScoreFromJS();
    }

    public void PushGetMaxLevel()
    {
        GetInfiniteBlocksMaxLevelFromJS();
    }

    public void PushSetMaxLevel()
    {
        SetInfiniteBlocksMaxLevelFromJS(maxLevel);
    }

    public void PushDestroyMaxLevel()
    {
        DestroyInfiniteBlocksMaxLevelFromJS();
    }
}
