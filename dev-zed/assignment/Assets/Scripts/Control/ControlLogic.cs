using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLogic : MonoBehaviour
{
    public void OnAwake()
    {
        Debug.Log("asdfafsd");
        string sContent = Resources.Load("Samples/json/dong").ToString();
        Debug.Log(sContent);
    }
    public void OnUpdate()
    {

    }
}
