using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLofiMusic : MonoBehaviour
{
    public GameObject AudioSrc;

    public void ToggleMusic()
    {
        if (AudioSrc.activeInHierarchy)
        {
            AudioSrc.SetActive(false);
        }
        else
        {
            AudioSrc.SetActive(true);
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
    }
}
