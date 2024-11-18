using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6, Twin Turbo";
    int carWeight = 1609;
    int yearMade = 2009;
    float maxAcceleration = 0.98f;
    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;


    void Start()
    {
        print("The Speed Racer model is " + carModel + " and it has a " + engineType + " engine");
        CheckWeight();
        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade + ".");
            int CarAge = CalculateAge(yearMade);
            {
                print("The car age is " + CarAge + "years old");
            }
        }
        else
        {
            print("The" + carModel + " was introduced in the 2010's");
            print("The" + carModel + "maximum acceleration is" + maxAcceleration + ".");
        }
        print(CheckCharacteristics());



    }



    void CheckWeight()
    {
        if (carWeight < 1500)
        {
            print("The Speed Race" + carModel + "weighs less than 1500kg");
        }
        else
        {
            print("The " + carModel + " weighs over 1500kg.");
        }

    }
    int CalculateAge(int yearMade)
    {
        return 2023 - yearMade;
    }
    string CheckCharacteristics()
    {
        if (isCarTypeSedan)
        {
            return "The car type is Sedan";
        }
        else if (hasFrontEngine)
        {
            return "the car isn't a Sedan but has a front engine";
        }
        else
        {
            return " The car is neither a Sedan nor does have a front engine";
        }
    }
} 
    
  
    

