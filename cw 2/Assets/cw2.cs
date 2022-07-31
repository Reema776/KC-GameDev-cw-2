using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
        string heroName = "Iron man";
        float heroHeight = 1.74f;
        int heroAge = 40;
    string heroSuperPower = "powered Armor";

        string villainName = "Thanos";
        float villainHeight = 2.52f;
        int villainAge = 1000;
    string villainSuperPower = "Omnipotent/infinity stones";

    void Start()
    {
        print("the super hero's name is " + heroName + " his hight is" + heroHeight + ", his age is" + heroAge + " years old and his superpower is " + heroSuperPower);
        print("the villain's name is " + villainName + " his hight is" + villainHeight + ", his age is around " + villainAge + " years old and his superpower is " + villainSuperPower);
        float ageDifference = villainAge - heroAge;
        print("age Difference is " + ageDifference);
        float heroHeight1 = 6.74f;
        string villainSuperPower1 = "None";
        print("the super hero's name is " + heroName + " his hight is" + heroHeight1 + ", his age is" + heroAge + " years old and his superpower is " + heroSuperPower);
        print("the villain's name is " + villainName + " his hight is" + villainHeight + ", his age is around " + villainAge + " years old and his superpower is " + villainSuperPower1 );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
