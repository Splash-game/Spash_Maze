using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterView : MonoBehaviour
{
    public GameObject BabyRabbit; //selection 0일때 
    public GameObject BabyCat; // 1
    public GameObject BabyBird; // 2

    public int selection = 0;

    // Update is called once per frame
    void Update()
    {
        if (selection == 0) //토끼
        {
            BabyRabbit.SetActive(true);
            BabyCat.SetActive(false);
            BabyBird.SetActive(false);
        }
        else if (selection == 1) //고양이
        {
            BabyRabbit.SetActive(false);
            BabyCat.SetActive(true);
            BabyBird.SetActive(false);
        }
        else if (selection == 2) //새 
        {
            BabyRabbit.SetActive(false);
            BabyCat.SetActive(false);
            BabyBird.SetActive(true);
        }

    }
}
