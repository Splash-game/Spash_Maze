using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHome : MonoBehaviour
{
    public void SceneChange()
    {
        SceneManager.LoadScene("HomeScene");
    }
}
