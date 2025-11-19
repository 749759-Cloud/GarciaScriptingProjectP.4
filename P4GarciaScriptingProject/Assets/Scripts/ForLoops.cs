using UnityEngine;
using System.Collections;

public class ForLoops : MonoBehaviour
{
    int numEnimies = 3;


    void Start()
    {
        for (int i = 0; i < numEnimies; i++)

        {
            Debug.Log("Creating enemy number: " + i);
        }
    }
}
