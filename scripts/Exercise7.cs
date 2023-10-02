using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        if (gameObject.name == "MyCylinder" && Input.GetKeyDown(KeyCode.A)) {
            Debug.Log("Key A was pressed");

            Material m_Material = GetComponent<Renderer>().material;

            Color newColor = new Color(Random.value, Random.value, Random.value);
            m_Material.color = newColor;
        } 
        else if (gameObject.name == "MyCube" && Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("Key Up Arrow was pressed");
            
            Material m_Material = GetComponent<Renderer>().material;

            Color newColor = new Color(Random.value, Random.value, Random.value);
            m_Material.color = newColor;
        }
    }
}
