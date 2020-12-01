using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColor());
    }


    IEnumerator ChangeColor()
    {
        while (true)
        {
            GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
            yield return new WaitForSeconds(1.0f);
        }
    }
}
