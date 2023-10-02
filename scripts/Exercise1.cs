using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    public int rangeMin = 0;
    public int rangeMax = 25;
    private int[] randomNumbers = new int[10];

    // Start is called before the first frame update
    void Start()
    {
        // Array of 10 random numbers between the range values
        for (int i = 0; i < 10; i++)
        {
            randomNumbers[i] = Random.Range(rangeMin, rangeMax);
        }
    }

    // Update is called once per frame
    void Update()
    {
        int randomPosition = Random.Range(0, 10);
        int randomValue = Random.Range(rangeMin, rangeMax);
        randomNumbers[randomPosition] = randomValue;

        string output = "[ ";
        // Print the array of random numbers to the console
        for (int i = 0; i < 10; i++)
        {
            if (randomNumbers[i] > 15)
            {
                output += randomNumbers[i] + " ";
            }
            else
            {
                output += "X ";
            }
        }
        output += "]";

        Debug.Log(output);
    }
}
