using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    public Vector3 firstVector;
    public Vector3 secondVector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float magnitudeFirstVector = firstVector.magnitude;
        float magnitudeSecondVector = secondVector.magnitude;

        float angleBetweenVectors = Vector3.Angle(firstVector, secondVector);
        float distanceBetweenVectors = Vector3.Distance(firstVector, secondVector);

        string higherVector = firstVector.y > secondVector.y ? "first" : "second";
        
        Debug.Log("The magnitude of the first vector is " + magnitudeFirstVector);
        Debug.Log("The magnitude of the second vector is " + magnitudeSecondVector);
        Debug.Log("The angle between the vectors is " + angleBetweenVectors);
        Debug.Log("The distance between the vectors is " + distanceBetweenVectors);
        Debug.Log("The " + higherVector + " vector is higher");
    }
}
