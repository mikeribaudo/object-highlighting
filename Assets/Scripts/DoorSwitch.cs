using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSwitch : MonoBehaviour, IInteractable
{
    public Door door;

    public bool doorSwitch;

    public bool switched;

    private void Start()
    {
        door.Down();
    }
    public void Update()
    {
        Debug.Log(switched);

        if (doorSwitch)
        {
            Interact();
            

        }
        doorSwitch = false;

    }

    public void Interact()
    {
        Switch();
    }

    void Switch()
    {
        switched = (switched == false) ? false : true;

        var y = door.transform.position.y;

        if (door != null)
        {
            if (switched == false &&  y == 0f)
            {
                door.Up();
                switched = true;

            }
            if (switched == true && y == 4f)
            {
                door.Down();
                switched = false;
            }
        }
    }
}
