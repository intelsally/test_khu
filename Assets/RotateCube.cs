using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public string someString;
    public float rotationDegree;
    public string stringWhenEnable = "Enabled";
    public GameObject cubeForCopy;
    public int amountOfCube = 20;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Multiply(20,30));
        for (var i = 0; i < amountOfCube; i++)
        {
            var cube = Instantiate(cubeForCopy);
            cube.transform.position = new Vector3(i, 0, 0);
        }
    }

   void OnEnable()
    {
        Debug.Log(stringWhenEnable);
    }

    void OnDisable()
    {
        Debug.Log("Disabled");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        { Rotate(); }
        else if (Input.GetMouseButton(1))
        { RotateBackward(); }
    }


    int Add(int a, int b)
    {
        return a + b;
    }

    int Multiply(int a, int b)
    {
        return a * b;
    } 
    
    void Rotate()
    {
        transform.Rotate(0, rotationDegree * Time.deltaTime, 0);
    }

    void RotateBackward()
    {
        transform.Rotate(0, rotationDegree * -Time.deltaTime, 0);
    }
}
