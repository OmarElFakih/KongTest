using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class KongregateBehaviour : MonoBehaviour
{

    [DllImport("__Internal")]
    private static extern void Hello();

    private void Start()
    {
     #if UNITY_WEBGL && !UNITY_EDITOR
        Hello();
     #else
        Debug.Log("Hello");
     #endif
    }
}
