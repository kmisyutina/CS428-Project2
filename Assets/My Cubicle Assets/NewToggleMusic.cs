using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewToggleMusic : MonoBehaviour
{
    public GameObject Laptop;

    public void ToggleMusic()
    {
        if (Laptop.GetComponent<AudioSource>().mute != false)
        {
            Laptop.GetComponent<AudioSource>().mute = false;
        }
        else
        {
            Laptop.GetComponent<AudioSource>().mute = true;
        }
    }

    private void Start()
    {

    }

    private void Update()
    {

    }
}
