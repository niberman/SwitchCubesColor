using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCycle : MonoBehaviour
{
    public int color;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CycleColor());
    }

    
    IEnumerator CycleColor()
    {
        while(true)
        {
          
            GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.black, Color.white, Mathf.PingPong(Time.time, 1));
            
            yield return new WaitForSeconds(1.0f);
        }
    }
}
