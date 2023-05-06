using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    [SerializeField] Text lastScore;
    [SerializeField] GameObject bronze;
    [SerializeField] GameObject silver;
    [SerializeField] GameObject gold;
    [SerializeField] GameObject platinum;
    Text myText;
    int lastScoreInt, bestScore;
    
    void OnEnable() => EventManager.Dead += OnDead;
    void OnDisable() => EventManager.Dead -= OnDead;

    void Start()
    {
        if (PlayerPrefs.HasKey("BestScore"))
        {
            bestScore = PlayerPrefs.GetInt("BestScore");
        }
        else
        {
            bestScore = 0;
        }

        myText = GetComponent<Text>();
    }

    void OnDead()
    {
        lastScoreInt = int.Parse(lastScore.text);
        if (lastScoreInt > bestScore)
        {
            bestScore = lastScoreInt;
            myText.text = bestScore.ToString();
            PlayerPrefs.SetInt("BestScore", lastScoreInt);
        }
        else
        {
            myText.text = bestScore.ToString();
        }

        switch (lastScoreInt)
        {
            case >= 100:
                platinum.SetActive(true);
                break;
            case >= 50:
                gold.SetActive(true);
                break;
            case >= 25:
                silver.SetActive(true);
                break;
            case >= 10:
                bronze.SetActive(true);
                break;
        }
    }
}
