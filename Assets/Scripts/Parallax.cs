using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parallax : MonoBehaviour
{
    [SerializeField] Text lastScore;
    [SerializeField] float speed, speedBase;
    MeshRenderer mesh;
    int currentScore;

    void OnEnable()
    {
        EventManager.Scored += OnScored;
        EventManager.Dead += OnDead;
    }
    void OnDisable()
    {
        EventManager.Scored -= OnScored;
        EventManager.Dead -= OnDead;
    }

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        mesh.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0);
    }

    void OnScored()
    {
        currentScore = int.Parse(lastScore.text);
        speed = (currentScore * (speedBase * 1.5f / 100)) + speedBase;
    }

    void OnDead()
    {
        speed = 0;
    }
}
