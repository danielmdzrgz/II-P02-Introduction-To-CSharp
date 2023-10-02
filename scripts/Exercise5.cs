using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject sphere = GameObject.FindWithTag("MySphere");
        Vector3 sphere_position = sphere.GetComponent<Transform>().position;
        Vector3 my_position = GetComponent<Transform>().position;
        
        float distance = Vector3.Distance(sphere_position, my_position);
        Debug.Log("The distance between the sphere and " + gameObject.name + " is " + distance);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
