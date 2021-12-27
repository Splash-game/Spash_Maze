using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearDirector : MonoBehaviour
{
    public int result = 0;
    GameObject resultText;

    // Start is called before the first frame update
    void Start()
    {
        this.resultText = GameObject.Find("Result");
    }

    // Update is called once per frame
    void Update()
    {
        if (result == 0)
            this.resultText.GetComponent<Text>().text = "Maze Complete";
        else if (result == 1)
            this.resultText.GetComponent<Text>().text = "Maze Incomplete";
    }
}
