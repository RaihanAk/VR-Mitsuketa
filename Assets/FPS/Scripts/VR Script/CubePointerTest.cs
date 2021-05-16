using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePointerTest : MonoBehaviour
{
    Color oriPurple;

    void Start()
    {
        GetComponent<Renderer>().material.color = oriPurple;
    }

    public void ChangeRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    public void ChangeCyan()
    {
        GetComponent<Renderer>().material.color = Color.cyan;
    }

    public void ChangeOriPurple()
    {
        GetComponent<Renderer>().material.color = oriPurple;
    }
}
