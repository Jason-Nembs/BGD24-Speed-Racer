using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    public string carMaker;
    public string carModel = "GTR R35";
    public string engineType = "V6, Twin Turbo";
    public int carWeight = 1609;
    public int yearMade = 2009;
    public float maxAcceleration = 0.98f;
    public bool isCarTypeSedan = false;
    public bool hasFrontEngine = true;

    public class Fuel
    {
        public int fuelLevel;
        public Fuel(int Amount)
        {
            fuelLevel = Amount;
        }
    }
    public Fuel carFuel = new Fuel(100);

    void Start()
    {
        print("The Speed Racer car " + carModel + " is a " + carMaker + " with a  " + engineType + " engine");

        CheckWeight();

        if (yearMade <= 2009)
        {
            print("The car was introduced in " + yearMade + ".");
            int CarAge = CalculateAge(yearMade);
            
            print("The car age is " + CarAge + "years old");
            
        }
        else
        {
            print("The" + carModel + " was introduced in the 2010's");
            print("The" + carModel + "maximum acceleration is" + maxAcceleration + ".");
        }
        print(CheckCharacteristics());



    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ConsumeFuel();
            CheckFuelLevel();
        }
    }

    void ConsumeFuel()
    {
        carFuel.fuelLevel = carFuel.fuelLevel - 10;
    }
    void CheckFuelLevel()
    {
        switch (carFuel.fuelLevel)
        {
            case 70:
                print("The fuel level is nearing two-thirds");
                break;
            case 50:
                print("fuel level is at half amount");
                break;
            case 10:
                print("Warning! Fuel level is critically low.");
                break;
            default:
                print("Nothing to report");
                break;


        }
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

    
  
    

