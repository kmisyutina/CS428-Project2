using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnOff : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;

    public void LightsOnOff()
    {
        if (light1.activeInHierarchy)
        {
            light1.SetActive(false);
            light2.SetActive(false);
        }
        else
        {
            light1.SetActive(true);
            light2.SetActive(true);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
