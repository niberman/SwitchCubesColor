using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
   
    public Color cubeColor;

    // Update is called once per frame
    void Update()
    {

        InputColor();
    }

    void InputColor()
    {
        GetComponent<MeshRenderer>().material.SetColor("_Color", cubeColor);

        if (Input.GetKeyDown(KeyCode.Space))
            cubeColor = new Color(Random.value, Random.value, Random.value);
        
    }
 
}
