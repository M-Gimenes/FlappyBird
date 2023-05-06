using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    Text text;
    int score;

    void OnEnable() => EventManager.Scored += OnScored;
    void OnDisable() => EventManager.Scored -= OnScored;

    void Start()
    {
        text = GetComponent<Text>();
    }

    void OnScored()
    {
        score++;
        text.text = score.ToString();
    }
}
