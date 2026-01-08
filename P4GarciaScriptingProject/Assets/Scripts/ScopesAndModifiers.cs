using UnityEngine;
using System.Collections;

public class ScopesAndModifiers : MonoBehaviour
{
    public int alpha = 5;


    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;


    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }


    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
    }

    void Update()
    {
        Debug.Log("Alpha is set to =: " + alpha);
    }
}