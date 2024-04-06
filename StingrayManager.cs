using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StingrayManager : MonoBehaviour
{
    public GameObject Stingray;
    public float value;
    public Vector3 sizeChange;
    private Vector3 startPosition;

    public void Start()
    {
        startPosition = new Vector3(Stingray.transform.position.x, Stingray.transform.position.y, Stingray.transform.position.z);
    }

    public void Moveleft()
    {
        value = value-0.1f;
        Stingray.transform.position = new Vector3(value, -437.8f, 680.9f);
         
    }

    public void Shrink()
    {
        Stingray.transform.localScale = Stingray.transform.localScale - sizeChange;

    }

    public void RotateLeft()
    {
        Stingray.transform.Rotate(0f, 15f, 0f);
    }

public void Grow()
{
    Stingray.transform.localScale = Stingray.transform.localScale + sizeChange;
}

public void ResetStingray()
{
    Stingray.transform.position = new Vector3(228.2f, -437.8f, 680.9f);
    Stingray.transform.rotation = Quaternion.Euler(new Vector3(-1.78f, 70.41f, -21.88f));
    Stingray.transform.localScale = new Vector3(2, 2, 2);
}  

}
