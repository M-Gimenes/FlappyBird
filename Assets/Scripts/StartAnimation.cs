using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    [SerializeField] float speed;
    Vector2 target;
    bool starting;

    void Start()
    {
        target = new Vector2(0, 0);
        starting = false;
    }

    void Update()
    {
        if (starting)
            transform.position = Vector2.Lerp(transform.position, target, speed * Time.deltaTime);
    }

    public void OnStarting()
    {
        starting = true;
    }
}
