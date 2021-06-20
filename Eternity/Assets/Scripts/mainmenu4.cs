using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu4 : MonoBehaviour
{
    // Start is called before the first frame update
    public void SoloPlay()
    {
        SceneManager.LoadScene(5);
    }

    public void MultiPlay()
    {
        SceneManager.LoadScene(3);
    }

    public void Back()
    {
        SceneManager.LoadScene(1);
    }
}
