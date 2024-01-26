
using UnityEngine;

public class RotateXCube : RotateCube
{
    public string someOtherString = "other string";
    [SerializeField]private string doNotShowString = "is showing?";
    public override void Update()
    {
        base.Update();
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(rotationDegree * Time.deltaTime, 0, 0);
        }
    }
}
