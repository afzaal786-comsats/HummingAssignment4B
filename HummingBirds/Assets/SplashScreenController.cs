using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashScreenController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(ToSplashOne());
    }

    IEnumerator ToSplashOne()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(1);
    }
}
