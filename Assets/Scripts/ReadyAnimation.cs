using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadyAnimation : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 target, move;
    bool ready;

    void Start()
    {
        target = new Vector2(-4.5f, 0);
        ready = false;
    }

    void Update()
    {
        if (ready)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        }
    }

    public void OnReady()
    {
        ready = true;
    }
}