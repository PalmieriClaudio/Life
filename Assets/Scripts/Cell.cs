using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    private bool isAlive;
    public bool IsAlive {get; set;}

    public void SetMatColor()
    {
        GetComponent<Renderer>().material.color = IsAlive ? Color.white : Color.black;
    }

    private void OnMouseOver()
    {
        if (!Input.GetMouseButtonDown(0)) return;

        IsAlive = !IsAlive;
    }
}
