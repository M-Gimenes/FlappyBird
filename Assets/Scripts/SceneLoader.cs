using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    int sceneIndex;
    [SerializeField] float time;
    [SerializeField] Animator anim;

    public void ChangeScene()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (sceneIndex == 1)
            StartCoroutine (Load(0));
        else
            StartCoroutine (Load(1));
    }

    IEnumerator Load(int index)
    {
        anim.SetTrigger("End");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(index);
    }
}