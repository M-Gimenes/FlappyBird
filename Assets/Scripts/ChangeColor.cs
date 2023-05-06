using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] Animator anim;
    public void ChangeBird(int bird)
    {
        if (bird == 0)
        {
            anim.SetBool("Blue", false);
            anim.SetBool("Red", false);
        }
        if (bird == 1)
        {
            anim.SetBool("Red", false);
            anim.SetBool("Blue", true);
        }
        if (bird == 2)
        {
            anim.SetBool("Blue", false);
            anim.SetBool("Red", true);
        }
        PlayerPrefs.SetInt("Color", bird);
    }

    void Start()
    {
        if (PlayerPrefs.HasKey("Color"))
        ChangeBird(PlayerPrefs.GetInt("Color"));
    }
}
