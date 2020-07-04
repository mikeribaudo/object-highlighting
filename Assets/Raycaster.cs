using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    RaycastHit hit;
    public float range;

    private List<GameObject> hits = new List<GameObject>();
    private void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.collider.tag == "Interactable")
        {
            hit.collider.gameObject.GetComponent<Outline>().OutlineMode = Outline.Mode.OutlineAll;
            hits.Add(hit.collider.gameObject);
        }
        else
        {
            foreach (GameObject hit in hits)
                hit.GetComponent<Outline>().OutlineMode = Outline.Mode.OutlineHidden;
            hits.Clear();
        }


        Debug.DrawRay(transform.position, transform.forward, Color.red, 500f);
    }
}
