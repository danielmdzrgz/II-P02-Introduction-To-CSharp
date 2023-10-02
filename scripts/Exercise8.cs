using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise8 : MonoBehaviour
{
    private GameObject[] spheres;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("MyCube");
        Vector3 cubePosition = cube.GetComponent<Transform>().position;
        spheres = GameObject.FindGameObjectsWithTag("sphere_group_2");

        foreach (GameObject sphere in spheres)
        {
            Vector3 spherePosition = sphere.GetComponent<Transform>().position;
            float distance = Vector3.Distance(spherePosition, cubePosition);
            Debug.Log("The distance between " + sphere.name + " and the cube is " + distance);
            sphere.GetComponent<Renderer>().material.color = Color.green;
        }

        // Increase the y position of the closest sphere to the cube
        float minDistance = 1000;
        GameObject closestSphere = null;

        foreach (GameObject sphere in spheres)
        {
            Vector3 spherePosition = sphere.GetComponent<Transform>().position;
            float distance = Vector3.Distance(spherePosition, cubePosition);
            
            if (distance < minDistance)
            {
                minDistance = distance;
                closestSphere = sphere;
            }
        }

        Vector3 closestSpherePosition = closestSphere.GetComponent<Transform>().position;
        closestSpherePosition.y = closestSpherePosition.y + 3;
        closestSphere.GetComponent<Transform>().position = closestSpherePosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Change the color of the farthest sphere when Space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            float maxDistance = -1;
            GameObject farthestSphere = null;
            foreach (GameObject sphere in spheres)
            {
                Vector3 spherePosition = sphere.GetComponent<Transform>().position;
                float distance = Vector3.Distance(spherePosition, Vector3.zero);
                if (distance > maxDistance)
                {
                    maxDistance = distance;
                    farthestSphere = sphere;
                }
            }

            Color newColor = new Color(Random.value, Random.value, Random.value);
            farthestSphere.GetComponent<Renderer>().material.color = newColor;
        }
    }
}
