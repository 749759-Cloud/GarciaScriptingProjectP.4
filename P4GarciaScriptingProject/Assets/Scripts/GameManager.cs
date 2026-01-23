using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject myObject;


    void Start()
    {
        Debug.Log("Activate Self: " + myObject.activeSelf);
        Debug.Log("Activate in Hierarchy" + myObject.activeInHierarchy);
    }
}