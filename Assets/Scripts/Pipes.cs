using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pipes : MonoBehaviour
{
    BoxCollider2D col;
    [SerializeField] Text lastScore;
    [SerializeField] float speedBase, speed;
    Vector2 target, range;
    int currentScore;

    void OnEnable() => EventManager.Dead += OnDead;
    void OnDisable() => EventManager.Dead -= OnDead;

    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        target = new Vector2(-4, transform.position.y);
        currentScore = int.Parse(lastScore.text);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == -4)
        {
            Destroy(gameObject);
        }
    }

    void OnDead()
    {
        target = transform.position;
        col.enabled = false;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 10)
        {
            if (speed < 3.5f)
            {
                speed = (currentScore * (speedBase * 1.5f/ 100)) + speedBase;
            }
        }
        if (other.gameObject.layer == 9)
        {
            range = new Vector2(5, Random.Range(-5.75f, -1.75f));
            Instantiate(gameObject, range, Quaternion.identity);
        }
    }
}
