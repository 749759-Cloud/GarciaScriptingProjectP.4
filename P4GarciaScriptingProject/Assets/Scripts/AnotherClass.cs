using UnityEngine;
using System.Collections;

public class AnotherClass
{
    public int apples = 100;
    public int bananas;


    private int stapler;
    private int sellotape;


    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit total: " + answer);
    }


    private void Officesort(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Suplies total: " + answer);
    }
}