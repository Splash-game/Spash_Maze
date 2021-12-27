using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSlider : MonoBehaviour
{
    public float Exp = 10;
    public int TotalExp = 100;
    
    Slider expSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        expSlider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        expSlider.value = Exp / (float)TotalExp;

        if (expSlider.value <= 0)
            transform.Find("Fill Area").gameObject.SetActive(false);
        else
            transform.Find("Fill Area").gameObject.SetActive(true);
    }
}
