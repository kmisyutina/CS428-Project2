using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLofiScreenshot : MonoBehaviour
{
    public GameObject Screenshot;

    public void ToggleObject()
    {
        if (Screenshot.activeInHierarchy)
        {
            Screenshot.SetActive(false);
        }
        else
        {
            Screenshot.SetActive(true);
        }
    }

    private void Start()
    {

    }

    private void Update()
    {

    }
}
