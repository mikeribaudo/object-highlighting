using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour, IInteractable
{
    public Light[] lights;

    private bool isEnabled = false;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Interact();
    }

    public void Interact()
    {
        Switch();
    }

    public void Switch()
    {
        isEnabled = (isEnabled == false) ? true : false;


        if (!isEnabled)
        {
            foreach (Light light in lights)
            {
                light.intensity = 1f;
            }
        }
        else
        {
            foreach (Light light in lights)
                light.intensity = 0f;
        }
    }


}
