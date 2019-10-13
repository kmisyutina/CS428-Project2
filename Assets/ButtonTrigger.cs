using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Material[] materials;
    //Renderer rend;
    private bool lightOn = false;

    public GameObject light1;
    public GameObject light2;

    // Start is called before the first frame update
    void Start()
    {
        //rend = GetComponent<Renderer>();
        //rend.enabled = true;
        //rend.sharedMaterial = materials[0];
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "button")
        {
            if (lightOn == false)
            {
                lightOn = true;
                //rend.sharedMaterial = materials[1];
                light1.GetComponent<MeshRenderer>().material = materials[1];
            }
            else
            {
                lightOn = false;
                //rend.sharedMaterial = materials[0];
                light1.GetComponent<MeshRenderer>().material = materials[0];
            }
        }
    }


}
