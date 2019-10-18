using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    public Material[] materials;
    private bool lightOn = false;

    [SerializeField]
    public GameObject light1;
    [SerializeField]
    public GameObject light2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private int counter = 0;
    private void Update()
    {
        if (counter % 30 == 0)
        {
            light1.GetComponent<MeshRenderer>().material = materials[1];
            counter = 0;
        }
        counter++;
    }


    /* private void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.tag == "button")
         {
             if (lightOn == false)
             {
                 lightOn = !lightOn;
                 light1.GetComponent <Renderer>().sharedMaterial = materials[1];
                 //light1.gameObject.SetActive(true);
                 //light2.gameObject.SetActive(true);
             }
             else
             {
                 lightOn = !lightOn;
                 light1.GetComponent<Renderer>().sharedMaterial = materials[0];
                 //light1.gameObject.SetActive(false);
                 //light2.gameObject.SetActive(false);

             }
         }
     }
     */


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "button")
        {
            if (lightOn == false)
            {
                lightOn = !lightOn;
                //rend.sharedMaterial = materials[1];
                light1.GetComponent<MeshRenderer>().material = materials[1];
            }
            else
            {
                lightOn = !lightOn;
                //rend.sharedMaterial = materials[0];
                light1.GetComponent<MeshRenderer>().material = materials[0];
            }
        }
    }
    
}
