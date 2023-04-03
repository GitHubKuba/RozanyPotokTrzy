using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunDirection : MonoBehaviour
{
    // Start is called before the first frame update


    public Quaternion tempRotation; 
    void Start()
    {
        transform.rotation = tempRotation;
    }

     public void SetHorizontalDirection(float hDirection)
    {
        Debug.Log(transform.name + ", Rotacja: " + transform.rotation.x);
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, hDirection, 0);
        tempRotation = transform.rotation; // aktualizujemy zmienn¹ tymczasow¹
    }

    public void SetVerticalDirection(float vDirection)
    {
        transform.rotation = Quaternion.Euler(vDirection, transform.rotation.eulerAngles.y, 0);
        tempRotation = transform.rotation; // aktualizujemy zmienn¹ tymczasow¹
    }
}
