using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float upDistance;
    public float upTravelTime;

    private float downTravelTime;
    private float downDistance;

    public int id;

    private void Start()
    {
        downDistance = 0f;
        downTravelTime = upTravelTime;

        gameObject.GetComponent<Outline>().OutlineMode = Outline.Mode.OutlineHidden;
    }

    public void Up() => transform.LeanMoveY(upDistance, upTravelTime);

    public void Down() => transform.LeanMoveY(downDistance, downTravelTime);
}
