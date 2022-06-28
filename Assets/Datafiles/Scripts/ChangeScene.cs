using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadFirstLaw()
    {
        SceneManager.LoadScene("FirstLaw");
    }

    public void LoadSecondLaw()
    {
        SceneManager.LoadScene("SecondLaw");
    }

    public void LoadThirdLaw()
    {
        SceneManager.LoadScene("ThirdLaw");
    }
}
