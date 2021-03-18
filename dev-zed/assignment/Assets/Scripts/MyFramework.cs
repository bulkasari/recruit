using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFramework : MonoBehaviour
{
    ControlLogic mControLogic;
    void Awake()
    {
        mControLogic = gameObject.AddComponent<ControlLogic>();
        mControLogic.OnAwake();
    }
    void Start()
    {

    }

    void Update()
    {
        mControLogic.OnUpdate();
    }
}
