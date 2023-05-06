using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject pipePrefab;
    Vector2 range;

    void OnEnable() => EventManager.Scored += OnScored;
    void OnDisable() => EventManager.Scored -= OnScored;

    void OnScored()
    {
        if (transform.position.x >= 0)
            transform.position = new Vector2(transform.position.x - 0.01f, transform.position.y);
    }
}
