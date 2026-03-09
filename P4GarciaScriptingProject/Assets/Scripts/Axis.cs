using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Axis : MonoBehaviour
{
    public float range;
    public Text textOutpuy;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        textOutpuy.text = "Value: " + h.ToString("F2");
    }
}
