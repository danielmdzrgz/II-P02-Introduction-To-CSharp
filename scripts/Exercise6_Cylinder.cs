using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise6_Cylinder : MonoBehaviour
{
    public Vector3 spherePosition;
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.FindWithTag("red_sphere");
        spherePosition = sphere.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject sphere = GameObject.FindWithTag("red_sphere");
        sphere.GetComponent<Transform>().position = spherePosition;

        Vector3 myPosition = GetComponent<Transform>().position;
        
        myPosition.x = spherePosition.x + 5;
        myPosition.y = spherePosition.y;
        myPosition.z = spherePosition.z;
        
        GetComponent<Transform>().position = myPosition;
    }
}
