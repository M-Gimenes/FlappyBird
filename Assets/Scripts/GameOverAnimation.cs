using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverAnimation : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 target;
    bool death;

    void OnEnable() => EventManager.Dead += OnDead;
    void OnDisable() => EventManager.Dead -= OnDead;

    void Start()
    {
        target = new Vector2(0,0);
        death = false;
    }

    void Update()
    {
        if (death)
            transform.position = Vector2.Lerp(transform.position, target, speed * Time.deltaTime);
    }

    void OnDead()
    {
        death = true;
    }
}
