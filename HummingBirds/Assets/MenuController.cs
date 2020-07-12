using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void loadPenguin()
    {
        SceneManager.LoadScene(2);
    }

    public void loadHummingBird()
    {
        SceneManager.LoadScene(3);
    }
}
