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
        CubeProperty cubeProperty = new CubeProperty();
        cubeProperty.cubeSize = 123123;
        cubeProperty.cubeName = gameObject.name;
        Debug.Log(cubeProperty.cubeSize); 
       
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
    public virtual void Update() // 상속받은 자식도 이건 갖게하자
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
