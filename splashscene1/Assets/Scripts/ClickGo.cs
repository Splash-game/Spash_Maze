using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickGo : MonoBehaviour
{
    public void SceneChange()
    {   if (ClickAnimals.SelectedAnimal != -1){SceneManager.LoadScene("HomeScene");}
    }
}

